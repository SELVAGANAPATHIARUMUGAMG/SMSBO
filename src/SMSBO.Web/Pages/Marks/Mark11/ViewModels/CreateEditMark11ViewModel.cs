using System;

using System.ComponentModel.DataAnnotations;

namespace SMSBO.Web.Pages.Marks.Mark11.ViewModels
{
    public class CreateEditMark11ViewModel
    {
        [Display(Name = "Mark11Tamil")]
        public int Tamil { get; set; }

        [Display(Name = "Mark11English")]
        public int English { get; set; }

        [Display(Name = "Mark11Maths")]
        public int Maths { get; set; }

        [Display(Name = "Mark11Science")]
        public int Science { get; set; }

        [Display(Name = "Mark11SocialScience")]
        public int SocialScience { get; set; }
    }
}