using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark12.ViewModels;

namespace SMSBO.Web.Pages.Marks.Mark12
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditMark12ViewModel ViewModel { get; set; }

        private readonly IMark12AppService _service;

        public EditModalModel(IMark12AppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<Mark12Dto, CreateEditMark12ViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMark12ViewModel, CreateUpdateMark12Dto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}