using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark12.ViewModels;

namespace SMSBO.Web.Pages.Marks.Mark12
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditMark12ViewModel ViewModel { get; set; }

        private readonly IMark12AppService _service;

        public CreateModalModel(IMark12AppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMark12ViewModel, CreateUpdateMark12Dto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}