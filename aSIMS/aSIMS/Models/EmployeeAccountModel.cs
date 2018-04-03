using aSIMS.Constants;
using aSIMS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.Models
{
    public class EmployeeAccountModel : BaseModel<EmployeeAccountModel>
    {

        public int UserID { get; set; }

        public int EntryUser { get; set; }

        public string UserCode { get; set; }


        // Required --

        [Required]
        [Display(Name = "UserName", ResourceType = typeof(LabelNaming))]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password", ResourceType = typeof(LabelNaming))]
        public string Password { get; set; }

        [Required]
        [Display(Name = "FullName", ResourceType = typeof(LabelNaming))]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAddress", ResourceType = typeof(LabelNaming))]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Address", ResourceType = typeof(LabelNaming))]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        private DateTime _dateOfBirth = DateTime.Now.Date;
        [Required]
        [Display(Name = "DOB", ResourceType = typeof(LabelNaming))]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }


        // Un-Required --

        [Display(Name = "CNIC", ResourceType = typeof(LabelNaming))]
        public string CNIC { get; set; }

        [Display(Name = "Phone", ResourceType = typeof(LabelNaming))]
        public string Phone { get; set; }

        [Display(Name = "Mobile", ResourceType = typeof(LabelNaming))]
        public string Mobile { get; set; }

        public string RoleName { get; set; }
        public string CityName { get; set; }
        public string DesignationName { get; set; }
        public string GenderName { get; set; }


        // INT-List --

        //Roles LIST
        public IEnumerable<BasicModel> Roles { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
        private int _roleID = 0;
        [Required]
        [Display(Name = "Role", ResourceType = typeof(LabelNaming))]
        public int RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
        }

        //Roles LIST
        public IEnumerable<BasicModel> Genders { get; set; }
        public IEnumerable<SelectListItem> GenderList { get; set; }
        private int _genderID = 0;
        [Required]
        [Display(Name = "Gender", ResourceType = typeof(LabelNaming))]
        public int GenderID
        {
            get { return _genderID; }
            set { _genderID = value; }
        }

        //Roles LIST
        public IEnumerable<BasicModel> Cities { get; set; }
        public IEnumerable<SelectListItem> CityList { get; set; }
        private int _cityID = 0;
        [Required]
        [Display(Name = "City", ResourceType = typeof(LabelNaming))]
        public int CityID
        {
            get { return _cityID; }
            set { _cityID = value; }
        }

        //Roles LIST
        public IEnumerable<BasicModel> Designations { get; set; }
        public IEnumerable<SelectListItem> DesignationList { get; set; }
        private int _designationID = 0;
        [Required]
        [Display(Name = "Designation", ResourceType = typeof(LabelNaming))]
        public int DesignationID
        {
            get { return _designationID; }
            set { _designationID = value; }
        }


        public EmployeeAccountModel()
        {
            BasicRepository _basic = new BasicRepository();
            BasicContants.StoredProcedure = "GetAdminRoles";
            Roles = _basic.Get();
            RoleList = Roles.ToRoleSelectListItems(RoleID);

            BasicContants.StoredProcedure = "GetGender";
            Genders = _basic.Get();
            GenderList = Genders.ToGenderSelectListItems(GenderID);

            BasicContants.StoredProcedure = "GetCity";
            Cities = _basic.Get();
            CityList = Cities.ToCitySelectListItems(CityID);

            BasicContants.StoredProcedure = "GetDesignation";
            Designations = _basic.Get();
            DesignationList = Designations.ToDesignationSelectListItems(DesignationID);
        }

    }
}