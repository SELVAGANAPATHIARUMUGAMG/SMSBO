using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Marks
{
    public class Mark12AppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IMark12AppService _mark12AppService;

        public Mark12AppServiceTests()
        {
            _mark12AppService = GetRequiredService<IMark12AppService>();
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
