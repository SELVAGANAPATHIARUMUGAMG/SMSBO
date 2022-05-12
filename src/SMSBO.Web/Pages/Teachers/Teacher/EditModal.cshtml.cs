using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Teachers;
using SMSBO.Teachers.Dtos;
using SMSBO.Web.Pages.Teachers.Teacher.ViewModels;

namespace SMSBO.Web.Pages.Teachers.Teacher
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditTeacherViewModel ViewModel { get; set; }

        private readonly ITeacherAppService _service;

        public EditModalModel(ITeacherAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<TeacherDto, CreateEditTeacherViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditTeacherViewModel, CreateUpdateTeacherDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}