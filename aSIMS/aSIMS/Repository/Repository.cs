using Microsoft.Practices.EnterpriseLibrary.Data;
using aSIMS.Common;
using aSIMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using aSIMS.Repository;

namespace aSIMS.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : BaseModel<T>, new()
    {
        public abstract string GetSPName { get; }
        public abstract string GetByIDSPName { get; }
        public abstract string GetByStringSPName { get; }
        public abstract string DeleteSPName { get; }
        //public abstract string DeleteTwoSPName { get; }
        public abstract string DeleteByStringSPName { get; }
        public abstract string CreateSPName { get; }
        public abstract string EditSPName { get; }
        public abstract string GetByModelSPName { get; }
        public string GetByParametersSPName { get; set; }

        Database db = Connection.GetDatabase();

        public IEnumerable<T> Get()
        {
            DataSet ds = db.ExecuteDataSet(GetSPName);
            return ds.Tables[0].ConvertToList<T>();
        }

        public IEnumerable<T> Get(T model)
        {
            var cmd = db.GetStoredProcCommand(GetByModelSPName);
            db.DiscoverParameters(cmd);
            foreach (SqlParameter b in cmd.Parameters)
            {
                if (b.Direction == ParameterDirection.Input)
                {
                    List<PropertyInfo> properties = typeof(T).GetProperties().ToList();
                    PropertyInfo info = properties.Where(prop => prop.Name == b.ParameterName.TrimStart('@')).FirstOrDefault();
                    var value = info.GetValue(model);
                    b.SqlValue = value;
                    b.Value = value;
                }
            }
            DataSet ds = db.ExecuteDataSet(cmd);
            return ds.Tables[0].ConvertToList<T>();
        }

        public IEnumerable<T> Get(params object[] param)
        {
            DataSet ds = db.ExecuteDataSet(GetByParametersSPName, param);
            return ds.Tables[0].ConvertToList<T>();
        }

        public T Get(int id)
        {
            DataSet ds = db.ExecuteDataSet(GetByIDSPName, id);
            T model = new T();
            return model.ToModel<T>(ds);
        }

        public T Get(string id)
        {
            DataSet ds = db.ExecuteDataSet(GetByStringSPName, id);
            T model = new T();
            return model.ToModel<T>(ds);
        }

        public int Delete(int id)
        {
            int confirm = db.ExecuteNonQuery(DeleteSPName, id);
            return confirm;
        }


        //public int DeleteTwo(int id, int user)
        //{
        //    int confirm = db.ExecuteNonQuery(DeleteTwoSPName, id, user);
        //    return confirm;
        //}

        public int Delete(string id)
        {
            int confirm = db.ExecuteNonQuery(DeleteByStringSPName, id);
            return confirm;
        }

        public int Create(T model)
        {
            var cmd = db.GetStoredProcCommand(CreateSPName);
            return ExecuteCommand(model, cmd);
        }

        public int Edit(T model)
        {
            var cmd = db.GetStoredProcCommand(EditSPName);
            return ExecuteCommand(model, cmd);
        }

        private int ExecuteCommand(T model, DbCommand cmd)
        {
            db.DiscoverParameters(cmd);
            foreach (SqlParameter b in cmd.Parameters)
            {
                if (b.Direction == ParameterDirection.Input)
                {
                    List<PropertyInfo> properties = typeof(T).GetProperties().ToList();
                    PropertyInfo info = properties.Where(prop => prop.Name == b.ParameterName.TrimStart('@')).FirstOrDefault();
                    var value = info.GetValue(model);
                    b.SqlValue = value;
                    b.Value = value;

                    if (value == null)
                    {
                        b.SqlValue = DBNull.Value;
                        b.Value = DBNull.Value;
                    }

                }
            }
            return db.ExecuteNonQuery(cmd);
        }
    }
}