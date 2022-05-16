using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Students;
using SMSBO.Students.Dtos;
using SMSBO.Web.Pages.Students.Student.ViewModels;

namespace SMSBO.Web.Pages.Students.Student
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditStudentViewModel ViewModel { get; set; }

        private readonly IStudentAppService _service;

        public CreateModalModel(IStudentAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditStudentViewModel, CreateUpdateStudentDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}