using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Students
{
    public class StudentAppServiceTests : SMSBOApplicationTestBase
    {
        private readonly IStudentAppService _studentAppService;

        public StudentAppServiceTests()
        {
            _studentAppService = GetRequiredService<IStudentAppService>();
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
