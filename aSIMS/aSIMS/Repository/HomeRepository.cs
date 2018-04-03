using aSIMS.Common;
using aSIMS.ViewModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace aSIMS.Repository
{
    public class HomeRepository : Repository<UserInfoViewModel>
    {
        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetDesignations"; } }
        public override string GetByIDSPName { get { return "GetDesignationsByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteDesignations"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateDesignations"; } }
        public override string EditSPName { get { return "UpdateDesignations"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

        public UserInfoViewModel LoginUser(CredentialsViewModel model)
        {
            DataSet ds = db.ExecuteDataSet("LoginAuthentication", model.Username, model.Password, model.UserTypeID);
            UserInfoViewModel Model = new UserInfoViewModel();
            return Model.ToModel<UserInfoViewModel>(ds);
        }
    }
}