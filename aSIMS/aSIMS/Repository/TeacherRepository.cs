using aSIMS.Common;
using aSIMS.Constants;
using aSIMS.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Repository
{
    public class TeacherRepository : Repository<TeacherModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return BasicContants.StoredProcedure; } }
        public override string GetByIDSPName { get { return "GetTeacherByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteTeacher"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateTeacher"; } }
        public override string EditSPName { get { return "UpdateTeacher"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}