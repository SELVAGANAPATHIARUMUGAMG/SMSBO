using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.Vehicledetails.Vehicledetail.ViewModels
{
    public class CreateEditVehicledetailViewModel
    {
        [Display(Name = "Number")]
        public int Number { get; set; }

        [Display(Name = "RegNumber")]
        public string RNumber { get; set; }

        [Display(Name = "StartFrom")]
        public string StartFrom { get; set; }

        [Display(Name = "End")]
        public string End { get; set; }

        [Display(Name = "NoOfSheets")]
        public int NoOfSheets { get; set; }
    }
}