using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Students
{
    public class Student11AppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IStudent11AppService _student11AppService;

        public Student11AppServiceTests()
        {
            _student11AppService = GetRequiredService<IStudent11AppService>();
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
