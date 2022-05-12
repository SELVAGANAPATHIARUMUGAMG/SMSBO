using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Teachers;
using SMSBO.Teachers.Dtos;
using SMSBO.Web.Pages.Teachers.Teacher.ViewModels;

namespace SMSBO.Web.Pages.Teachers.Teacher
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditTeacherViewModel ViewModel { get; set; }

        private readonly ITeacherAppService _service;

        public CreateModalModel(ITeacherAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditTeacherViewModel, CreateUpdateTeacherDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}