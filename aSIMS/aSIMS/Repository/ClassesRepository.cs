using aSIMS.Common;
using aSIMS.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Repository
{
    public class ClassesRepository : Repository<ClassesModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetClasses"; } }
        public override string GetByIDSPName { get { return "GetClassByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteClass"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateClass"; } }
        public override string EditSPName { get { return "UpdateClass"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }

    public class SectionsRepository : Repository<SectionsModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetSections"; } }
        public override string GetByIDSPName { get { return "GetSectionByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteSection"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateSection"; } }
        public override string EditSPName { get { return "UpdateSection"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}