using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Students;
using SMSBO.Students.Dtos;
using SMSBO.Web.Pages.Students.Student11.ViewModels;

namespace SMSBO.Web.Pages.Students.Student11
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditStudent11ViewModel ViewModel { get; set; }

        private readonly IStudent11AppService _service;

        public CreateModalModel(IStudent11AppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditStudent11ViewModel, CreateUpdateStudent11Dto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}