using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace SMSBO.Web.Pages.Marks.Mark
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public EditMarkViewModel ViewModel { get; set; }
        public List<SelectListItem> Students { get; set; }


        private readonly IMarkAppService _service;

        public EditModalModel(IMarkAppService service)
        {
            _service = service;
        }

        public  async Task OnGetAsync(Guid id)
        {
            var markDto = await _service.GetAsync(id);
            ViewModel = ObjectMapper.Map<MarkDto, EditMarkViewModel>(markDto);

            var studentLookup = await _service.GetAuthorLookupAsync();
            Students = studentLookup.Items
                .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                .ToList();
        }

        public  async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, ObjectMapper.Map<EditMarkViewModel, CreateUpdateMarkDto>(ViewModel));
            return NoContent();
        }
        public class EditMarkViewModel
        {
            [HiddenInput]
            public Guid Id { get; set; }
            [SelectItems(nameof(Students))]
            [DisplayName("Name")]
            public Guid StudentId { get; set; }

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
    
}