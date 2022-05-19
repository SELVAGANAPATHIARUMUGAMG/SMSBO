using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark.ViewModels;

namespace SMSBO.Web.Pages.Marks.Mark
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditMarkViewModel ViewModel { get; set; }

        private readonly IMarkAppService _service;

        public CreateModalModel(IMarkAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMarkViewModel, CreateUpdateMarkDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}