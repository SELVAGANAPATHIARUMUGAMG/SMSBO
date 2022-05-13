using System;
using Volo.Abp.Domain.Repositories;

namespace SMSBO.Vehicledetails
{
    public interface IVehicledetailRepository : IRepository<Vehicledetail, Guid>
    {
    }
}