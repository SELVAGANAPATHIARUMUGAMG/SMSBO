using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace SMSBO.Teachers
{
    public class TeacherAppServiceTests : SMSBOApplicationTestBase
    {
        private readonly ITeacherAppService _teacherAppService;

        public TeacherAppServiceTests()
        {
            _teacherAppService = GetRequiredService<ITeacherAppService>();
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
