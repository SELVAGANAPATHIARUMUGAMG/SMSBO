using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Students;
using SMSBO.Students.Dtos;
using SMSBO.Web.Pages.Students.Student12.ViewModels;

namespace SMSBO.Web.Pages.Students.Student12
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditStudent12ViewModel ViewModel { get; set; }

        private readonly IStudent12AppService _service;

        public EditModalModel(IStudent12AppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<Student12Dto, CreateEditStudent12ViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditStudent12ViewModel, CreateUpdateStudent12Dto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}