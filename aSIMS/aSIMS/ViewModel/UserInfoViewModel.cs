using aSIMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.ViewModel
{
    public class UserInfoViewModel : BaseModel<UserInfoViewModel>
    {

        public int UserID { get; set; }

        public string FullName { get; set; }

        public int RoleID { get; set; }

        public string Designation { get; set; }

    }
}