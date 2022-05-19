using SMSBO.Marks;
using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.Marks.Mark.ViewModels
{
    public class CreateEditMarkViewModel
    {
        [Display(Name = "ExamType")]
        public ExamTypes ExamType { get; set; }

        [Display(Name = "Tamil")]
        public int Tamil { get; set; }

        [Display(Name = "English")]
        public int English { get; set; }

        [Display(Name = "Maths")]
        public int Maths { get; set; }

        [Display(Name = "Science")]
        public int Science { get; set; }

        [Display(Name = "SocialScience")]
        public int SocialScience { get; set; }
    }
}