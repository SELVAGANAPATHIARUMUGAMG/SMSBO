using System;
using System.Threading.Tasks;
using SMSBO.Students;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Students
{
    public class StudentRepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentRepositoryTests()
        {
            _studentRepository = GetRequiredService<IStudentRepository>();
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
