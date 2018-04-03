using aSIMS.Common;
using aSIMS.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Repository
{
    public class StudentRepository : Repository<StudentModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetStudents"; } }
        public override string GetByIDSPName { get { return "GetStudentByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteStudent"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateStudent"; } }
        public override string EditSPName { get { return "UpdateStudent"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}