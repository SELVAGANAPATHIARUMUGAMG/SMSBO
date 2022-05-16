using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Students;
using SMSBO.Students.Dtos;
using SMSBO.Web.Pages.Students.Student12.ViewModels;

namespace SMSBO.Web.Pages.Students.Student12
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditStudent12ViewModel ViewModel { get; set; }

        private readonly IStudent12AppService _service;

        public CreateModalModel(IStudent12AppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditStudent12ViewModel, CreateUpdateStudent12Dto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}