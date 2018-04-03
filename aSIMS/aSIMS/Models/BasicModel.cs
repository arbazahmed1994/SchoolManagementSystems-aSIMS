using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Models
{
    public class BasicModel : BaseModel<BasicModel>
    {

        public int RoleID { get; set; }
        public string RoleName { get; set; }


        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }


        public int GenderID { get; set; }
        public string GenderName { get; set; }


        public int DesignationID { get; set; }
        public string DesignationName { get; set; }


        public int CityID { get; set; }
        public string CityName { get; set; }

        
        public int GroupSectionID { get; set; }
        public string GroupSectionName { get; set; }

    }
}