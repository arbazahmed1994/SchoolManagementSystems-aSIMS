using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aSIMS.Models
{
    public class ParentModel : BaseModel<ParentModel>
    {

        public int ParentID { get; set; }

        [Required]
        [Display(Name = "ParentName", ResourceType = typeof(LabelNaming))]
        public string ParentName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "EmailAddress", ResourceType = typeof(LabelNaming))]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Password", ResourceType = typeof(LabelNaming))]
        public string Password { get; set; }

        [Display(Name = "Phone", ResourceType = typeof(LabelNaming))]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Mobile", ResourceType = typeof(LabelNaming))]
        public string Mobile { get; set; }

        [Required]
        [Display(Name = "Address", ResourceType = typeof(LabelNaming))]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Profession", ResourceType = typeof(LabelNaming))]
        public string Profession { get; set; }

        public int EntryUser { get; set; }

    }
}