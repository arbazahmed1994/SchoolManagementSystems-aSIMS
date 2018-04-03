using aSIMS.Constants;
using aSIMS.Models;
using aSIMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.ViewModel
{
    public class CredentialsViewModel : BaseModel<CredentialsViewModel>
    {

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //UserTypes LIST
        public IEnumerable<BasicModel> UserTypes { get; set; }
        public IEnumerable<SelectListItem> UserTypeList { get; set; }
        private int _userTypeID = 0;
        [Required]
        [Display(Name = "UserType", ResourceType = typeof(LabelNaming))]
        public int UserTypeID
        {
            get { return _userTypeID; }
            set { _userTypeID = value; }
        }

        public CredentialsViewModel()
        {
            BasicRepository _basic = new BasicRepository();
            BasicContants.StoredProcedure = "GetUserType";
            UserTypes = _basic.Get();
            UserTypeList = UserTypes.ToUserTypeSelectListItems(UserTypeID);
        }
    }
}