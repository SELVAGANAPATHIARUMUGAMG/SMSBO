using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.OfficeStaffs;
using SMSBO.OfficeStaffs.Dtos;
using SMSBO.Web.Pages.OfficeStaffs.OfficeStaff.ViewModels;

namespace SMSBO.Web.Pages.OfficeStaffs.OfficeStaff
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditOfficeStaffViewModel ViewModel { get; set; }

        private readonly IOfficeStaffAppService _service;

        public CreateModalModel(IOfficeStaffAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditOfficeStaffViewModel, CreateUpdateOfficeStaffDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}