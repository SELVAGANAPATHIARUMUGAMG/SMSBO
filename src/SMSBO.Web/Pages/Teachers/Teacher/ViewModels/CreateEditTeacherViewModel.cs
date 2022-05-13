using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.Teachers.Teacher.ViewModels
{
    public class CreateEditTeacherViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        //[Display(Name = "DOB")]
        //public DateTime DOB { get; set; }

        [Display(Name = "ContextNumber")]
        public string ContextNumber { get; set; }

        [Display(Name = "EmailID")]
        public string EmailID { get; set; }
    }
}