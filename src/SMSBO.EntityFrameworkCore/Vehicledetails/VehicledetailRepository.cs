using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Vehicledetails
{
    public class VehicledetailRepository : EfCoreRepository<SMSBODbContext, Vehicledetail, Guid>, IVehicledetailRepository
    {
        public VehicledetailRepository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}