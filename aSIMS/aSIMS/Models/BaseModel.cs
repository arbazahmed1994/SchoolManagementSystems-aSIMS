using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace aSIMS.Models
{
    public class BaseModel<T>
    {
        private static Dictionary<Type, IList<PropertyInfo>> typeDictionary = new Dictionary<Type, IList<PropertyInfo>>();

        public T ToModel<T>(DataSet ds) where T : new()
        {
            var type = typeof(T);
            if (!typeDictionary.ContainsKey(typeof(T)))
            {
                typeDictionary.Add(type, type.GetProperties().ToList());
            }

            IList<PropertyInfo> properties = typeDictionary[typeof(T)];
            T item = new T();
            if (ds.Tables[0].Rows.Count == 0)
                return item;

            foreach (var property in properties)
            {
                if (ds.Tables[0].Columns.Contains(property.Name))
                    if (ds.Tables[0].Rows[0][property.Name] != DBNull.Value && ds.Tables[0].Rows[0][property.Name] != null)
                        property.SetValue(item, ds.Tables[0].Rows[0][property.Name], null);
            }
            return item;
        }
    }
}