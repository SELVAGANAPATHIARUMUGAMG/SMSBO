using System;
using SMSBO.Permissions;
using SMSBO.Vehicledetails.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Vehicledetails
{
    public class VehicledetailAppService : CrudAppService<Vehicledetail, VehicledetailDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateVehicledetailDto, CreateUpdateVehicledetailDto>,
        IVehicledetailAppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Vehicledetail.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Vehicledetail.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Vehicledetail.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Vehicledetail.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Vehicledetail.Delete;

        private readonly IVehicledetailRepository _repository;
        
        public VehicledetailAppService(IVehicledetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
