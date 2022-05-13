using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.OfficeStaffs
{
    public class OfficeStaffAppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IOfficeStaffAppService _officeStaffAppService;

        public OfficeStaffAppServiceTests()
        {
            _officeStaffAppService = GetRequiredService<IOfficeStaffAppService>();
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
