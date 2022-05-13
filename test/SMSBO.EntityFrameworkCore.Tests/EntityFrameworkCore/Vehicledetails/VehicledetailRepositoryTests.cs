using System;
using System.Threading.Tasks;
using SMSBO.Vehicledetails;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Vehicledetails
{
    public class VehicledetailRepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IVehicledetailRepository _vehicledetailRepository;

        public VehicledetailRepositoryTests()
        {
            _vehicledetailRepository = GetRequiredService<IVehicledetailRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
