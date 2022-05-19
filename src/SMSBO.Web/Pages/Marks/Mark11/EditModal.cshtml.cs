using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark11.ViewModels;

namespace SMSBO.Web.Pages.Marks.Mark11
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditMark11ViewModel ViewModel { get; set; }

        private readonly IMark11AppService _service;

        public EditModalModel(IMark11AppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<Mark11Dto, CreateEditMark11ViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMark11ViewModel, CreateUpdateMark11Dto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}