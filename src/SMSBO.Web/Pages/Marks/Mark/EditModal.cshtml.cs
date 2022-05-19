using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark.ViewModels;

namespace SMSBO.Web.Pages.Marks.Mark
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditMarkViewModel ViewModel { get; set; }

        private readonly IMarkAppService _service;

        public EditModalModel(IMarkAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<MarkDto, CreateEditMarkViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMarkViewModel, CreateUpdateMarkDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}