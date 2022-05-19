using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Marks
{
    public class MarkAppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IMarkAppService _markAppService;

        public MarkAppServiceTests()
        {
            _markAppService = GetRequiredService<IMarkAppService>();
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
