using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Students
{
    public class Student12AppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IStudent12AppService _student12AppService;

        public Student12AppServiceTests()
        {
            _student12AppService = GetRequiredService<IStudent12AppService>();
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
