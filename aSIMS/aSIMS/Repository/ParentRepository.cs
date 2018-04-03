using aSIMS.Common;
using aSIMS.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Repository
{
    public class ParentRepository : Repository<ParentModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetParents"; } }
        public override string GetByIDSPName { get { return "GetParentByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteParent"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateParent"; } }
        public override string EditSPName { get { return "UpdateParent"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}