using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark11.ViewModels;

namespace SMSBO.Web.Pages.Marks.Mark11
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditMark11ViewModel ViewModel { get; set; }

        private readonly IMark11AppService _service;

        public CreateModalModel(IMark11AppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMark11ViewModel, CreateUpdateMark11Dto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}