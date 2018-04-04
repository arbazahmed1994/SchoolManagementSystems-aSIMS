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
    public class StudentModel : BaseModel<StudentModel>
    {

        // UN-REQUIRED --

        public int StudentID { get; set; }
        
        public int EntryUser { get; set; }

        [Display(Name = "IsPassOut", ResourceType = typeof(LabelNaming))]
        public bool IsPassOut { get; set; }

        [Display(Name = "IsDropOut", ResourceType = typeof(LabelNaming))]
        public bool IsDropOut { get; set; }

        [Display(Name = "ParentID", ResourceType = typeof(LabelNaming))]
        public string ParentName { get; set; }
        [Display(Name = "SectionID", ResourceType = typeof(LabelNaming))]
        public string SectionName { get; set; }
        [Display(Name = "Gender", ResourceType = typeof(LabelNaming))]
        public string GenderName { get; set; }
        [Display(Name = "TransportID", ResourceType = typeof(LabelNaming))]
        public string TransportName { get; set; }
        

        // REQUIRED --

        [Required]
        [Display(Name = "StudentName", ResourceType = typeof(LabelNaming))]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "RollNumber", ResourceType = typeof(LabelNaming))]
        public string RollNumber { get; set; }

        [Required]
        [Display(Name = "Phone", ResourceType = typeof(LabelNaming))]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAddress", ResourceType = typeof(LabelNaming))]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Address", ResourceType = typeof(LabelNaming))]
        public string Address { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Photo", ResourceType = typeof(LabelNaming))]
        public string Photo { get; set; }

        private DateTime _dob = DateTime.Now.Date;
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "DOB", ResourceType = typeof(LabelNaming))]
        public DateTime DateOfBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }


        // LIST MODEL

        public IEnumerable<ParentModel> Parents { get; set; }
        public IEnumerable<SelectListItem> ParentList { get; set; }
        private int _parentID = 0;
        [Required]
        [Display(Name = "ParentID", ResourceType = typeof(LabelNaming))]
        public int ParentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }

        public IEnumerable<SectionsModel> Sections { get; set; }
        public IEnumerable<SelectListItem> SectionList { get; set; }
        private int _sectionID = 0;
        [Required]
        [Display(Name = "SectionID", ResourceType = typeof(LabelNaming))]
        public int SectionID
        {
            get { return _sectionID; }
            set { _sectionID = value; }
        }

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

        public IEnumerable<TransportModel> Transports { get; set; }
        public IEnumerable<SelectListItem> TransportList { get; set; }
        private int _transportID = 0;
        [Required]
        [Display(Name = "TransportID", ResourceType = typeof(LabelNaming))]
        public int TransportID
        {
            get { return _transportID; }
            set { _transportID = value; }
        }

        public IEnumerable<BasicModel> Students { get; set; }
        public IEnumerable<SelectListItem> StudentList { get; set; }
        private int _studentTypeID = 0;
        [Required]
        [Display(Name = "StudentTypeID", ResourceType = typeof(LabelNaming))]
        public int StudentTypeID
        {
            get { return _studentTypeID; }
            set { _studentTypeID = value; }
        }


        public void FillData()
        {
            BasicRepository _basic = new BasicRepository();
            BasicContants.StoredProcedure = "GetGender";
            Genders = _basic.Get();
            GenderList = Genders.ToGenderSelectListItems(GenderID);

            BasicContants.StoredProcedure = "GetStudentType";
            Students = _basic.Get();
            StudentList = Students.ToStudentTypeSelectListItems(StudentTypeID);

            SectionsRepository _section = new SectionsRepository();
            BasicContants.StoredProcedure = "GetFullSectionName";
            Sections = _section.Get();
            SectionList = Sections.ToSectionSelectListItems(SectionID);

            ParentRepository _parent = new ParentRepository();
            Parents = _parent.Get();
            ParentList = Parents.ToParentSelectListItems(ParentID);

            TransportRepository _transport = new TransportRepository();
            Transports = _transport.Get();
            TransportList = Transports.ToTransportSelectListItems(TransportID);

        }

    }
}