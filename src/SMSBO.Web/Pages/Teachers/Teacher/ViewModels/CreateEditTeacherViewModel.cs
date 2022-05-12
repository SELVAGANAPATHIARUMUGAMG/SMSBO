using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.Teachers.Teacher.ViewModels
{
    public class CreateEditTeacherViewModel
    {
        [Display(Name = "TeacherName")]
        public string Name { get; set; }

        [Display(Name = "TeacherAge")]
        public int Age { get; set; }

        [Display(Name = "TeacherDOB")]
        public DateTime DOB { get; set; }

        [Display(Name = "TeacherContextNumber")]
        public string ContextNumber { get; set; }

        [Display(Name = "TeacherEmailID")]
        public string EmailID { get; set; }
    }
}