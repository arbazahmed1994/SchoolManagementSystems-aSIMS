using aSIMS.Common;
using aSIMS.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Repository
{
    public class EmployeeAccountRepository : Repository<EmployeeAccountModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetEmployeeAccount"; } }
        public override string GetByIDSPName { get { return "GetEmployeeAccountByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteEmployeeAccount"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateEmployeeAccount"; } }
        public override string EditSPName { get { return "UpdateEmployeeAccount"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}