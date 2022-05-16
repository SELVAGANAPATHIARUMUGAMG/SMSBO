using System;
using System.Threading.Tasks;
using SMSBO.Students;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Students
{
    public class Student11RepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IStudent11Repository _student11Repository;

        public Student11RepositoryTests()
        {
            _student11Repository = GetRequiredService<IStudent11Repository>();
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
