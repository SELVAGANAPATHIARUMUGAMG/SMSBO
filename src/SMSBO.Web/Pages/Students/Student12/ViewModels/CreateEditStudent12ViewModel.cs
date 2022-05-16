using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.Students.Student12.ViewModels
{
    public class CreateEditStudent12ViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "RegNumber")]
        public string RegNumber { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Mobile")]
        public string MobileNumber { get; set; }

        [Display(Name = "EmailID")]
        public string EmailID { get; set; }
    }
}