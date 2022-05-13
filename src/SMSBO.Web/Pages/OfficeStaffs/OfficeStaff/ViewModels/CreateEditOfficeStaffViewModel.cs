using SMSBO.OfficeStaffs;
using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.OfficeStaffs.OfficeStaff.ViewModels
{
    public class CreateEditOfficeStaffViewModel
    {
        [Display(Name = "StaffName")]
        public string Name { get; set; }

        [Display(Name = "ContextNo")]
        public string ContextNo { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Position")]
        public Position Position { get; set; }

        [Display(Name = "StaffAddress")]
        public string Address { get; set; }
    }
}