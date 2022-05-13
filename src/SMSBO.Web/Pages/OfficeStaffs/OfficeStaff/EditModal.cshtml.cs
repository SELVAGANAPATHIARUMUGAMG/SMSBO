using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.OfficeStaffs;
using SMSBO.OfficeStaffs.Dtos;
using SMSBO.Web.Pages.OfficeStaffs.OfficeStaff.ViewModels;

namespace SMSBO.Web.Pages.OfficeStaffs.OfficeStaff
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditOfficeStaffViewModel ViewModel { get; set; }

        private readonly IOfficeStaffAppService _service;

        public EditModalModel(IOfficeStaffAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<OfficeStaffDto, CreateEditOfficeStaffViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditOfficeStaffViewModel, CreateUpdateOfficeStaffDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}