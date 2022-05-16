using System;
using System.Threading.Tasks;
using SMSBO.Students;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Students
{
    public class Student12RepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IStudent12Repository _student12Repository;

        public Student12RepositoryTests()
        {
            _student12Repository = GetRequiredService<IStudent12Repository>();
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
