using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMSBO.Vehicledetails;
using SMSBO.Vehicledetails.Dtos;
using SMSBO.Web.Pages.Vehicledetails.Vehicledetail.ViewModels;

namespace SMSBO.Web.Pages.Vehicledetails.Vehicledetail
{
    public class CreateModalModel : SMSBOPageModel
    {
        [BindProperty]
        public CreateEditVehicledetailViewModel ViewModel { get; set; }

        private readonly IVehicledetailAppService _service;

        public CreateModalModel(IVehicledetailAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditVehicledetailViewModel, CreateUpdateVehicledetailDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}