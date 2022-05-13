using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Vehicledetails
{
    public class VehicledetailAppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IVehicledetailAppService _vehicledetailAppService;

        public VehicledetailAppServiceTests()
        {
            _vehicledetailAppService = GetRequiredService<IVehicledetailAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
