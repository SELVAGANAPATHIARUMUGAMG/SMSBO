using System;
using System.Threading.Tasks;
using SMSBO.Teachers;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Teachers
{
    public class TeacherRepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherRepositoryTests()
        {
            _teacherRepository = GetRequiredService<ITeacherRepository>();
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
