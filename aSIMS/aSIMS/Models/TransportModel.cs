using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aSIMS.Models
{
    public class TransportModel : BaseModel<TransportModel>
    {
        
        public int TransportID { get; set; }

        [Required]
        [Display(Name = "TransportName", ResourceType = typeof(LabelNaming))]
        public string TransportName { get; set; }

        [Required]
        [Display(Name = "NumberOfVehicle", ResourceType = typeof(LabelNaming))]
        public int NumberOfVehicle { get; set; }

        [Required]
        [Display(Name = "VehicleNumber", ResourceType = typeof(LabelNaming))]
        public string VehicleNumber { get; set; }

        [Required]
        [Display(Name = "DriverCNIC", ResourceType = typeof(LabelNaming))]
        public string DriverCNIC { get; set; }

        [Required]
        [Display(Name = "DriverMobile", ResourceType = typeof(LabelNaming))]
        public string DriverMobile { get; set; }

        [Display(Name = "RouteFare", ResourceType = typeof(LabelNaming))]
        public double RouteFare { get; set; }

        [Display(Name = "RouteArea", ResourceType = typeof(LabelNaming))]
        public string RouteArea { get; set; }

        [Display(Name = "Discription", ResourceType = typeof(LabelNaming))]
        public string Description { get; set; }

        public int EntryUser { get; set; }

    }
}