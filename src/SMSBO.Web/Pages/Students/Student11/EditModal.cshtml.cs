using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Students;
using SMSBO.Students.Dtos;
using SMSBO.Web.Pages.Students.Student11.ViewModels;

namespace SMSBO.Web.Pages.Students.Student11
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditStudent11ViewModel ViewModel { get; set; }

        private readonly IStudent11AppService _service;

        public EditModalModel(IStudent11AppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<Student11Dto, CreateEditStudent11ViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditStudent11ViewModel, CreateUpdateStudent11Dto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}