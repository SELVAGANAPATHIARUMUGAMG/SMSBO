using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Vehicledetails;
using SMSBO.Vehicledetails.Dtos;
using SMSBO.Web.Pages.Vehicledetails.Vehicledetail.ViewModels;

namespace SMSBO.Web.Pages.Vehicledetails.Vehicledetail
{
    public class EditModalModel : SMSBOPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditVehicledetailViewModel ViewModel { get; set; }

        private readonly IVehicledetailAppService _service;

        public EditModalModel(IVehicledetailAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<VehicledetailDto, CreateEditVehicledetailViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditVehicledetailViewModel, CreateUpdateVehicledetailDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}