using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.Marks.Mark12.ViewModels
{
    public class CreateEditMark12ViewModel
    {
        [Display(Name = "Mark12Language")]
        public int Language { get; set; }

        [Display(Name = "Mark12English")]
        public int English { get; set; }

        [Display(Name = "Mark12Maths")]
        public int Maths { get; set; }

        [Display(Name = "Mark12Physcics")]
        public int Physcics { get; set; }

        [Display(Name = "Mark12Chemistry")]
        public int Chemistry { get; set; }

        [Display(Name = "Mark12ComputerScience")]
        public int ComputerScience { get; set; }
    }
}