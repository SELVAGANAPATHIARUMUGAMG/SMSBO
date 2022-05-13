using System;
using SMSBO.Vehicledetails.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Vehicledetails
{
    public interface IVehicledetailAppService :
        ICrudAppService< 
            VehicledetailDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateVehicledetailDto,
            CreateUpdateVehicledetailDto>
    {

    }
}