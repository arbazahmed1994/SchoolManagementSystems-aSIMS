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
    public class ClassesModel : BaseModel<ClassesModel>
    {

        // UN-Required

        public int ClassID { get; set; }

        //public string TeacherName { get; set; }


        // REQUIRED

        [Required]
        [Display(Name = "ClassName", ResourceType = typeof(LabelNaming))]
        public string ClassName { get; set; }

        [Required]
        [Display(Name = "ClassNumericName", ResourceType = typeof(LabelNaming))]
        public string ClassNumericName { get; set; }

    }

    public class SectionsModel : BaseModel<SectionsModel>
    {

        public int SectionID { get; set; }

        public string ClassName { get; set; }
        public string TeacherName { get; set; }

        [Required]
        [Display(Name = "SectionName", ResourceType = typeof(LabelNaming))]
        public string SectionName { get; set; }


        //Teachers LIST
        public IEnumerable<TeacherModel> Teachers { get; set; }
        public IEnumerable<SelectListItem> TeacherList { get; set; }
        private int _teacherID = 0;
        [Display(Name = "TeacherID", ResourceType = typeof(LabelNaming))]
        public int TeacherID
        {
            get { return _teacherID; }
            set { _teacherID = value; }
        }

        // Class LIST
        public IEnumerable<ClassesModel> Classes { get; set; }
        public IEnumerable<SelectListItem> ClassList { get; set; }
        private int _classID = 0;
        [Display(Name = "ClassID", ResourceType = typeof(LabelNaming))]
        public int ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }


        // CONSTRUCTOR
        public SectionsModel()
        {
            TeacherRepository _teacherRep = new TeacherRepository();
            BasicContants.StoredProcedure = "GetFullTeacherName";
            Teachers = _teacherRep.Get();
            TeacherList = Teachers.ToTeacherSelectListItems(TeacherID);
        
            ClassesRepository _classRep = new ClassesRepository();
            Classes = _classRep.Get();
            ClassList = Classes.ToClassSelectListItems(ClassID);
        }


    }
}