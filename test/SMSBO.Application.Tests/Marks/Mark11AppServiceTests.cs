using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Marks
{
    public class Mark11AppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IMark11AppService _mark11AppService;

        public Mark11AppServiceTests()
        {
            _mark11AppService = GetRequiredService<IMark11AppService>();
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
