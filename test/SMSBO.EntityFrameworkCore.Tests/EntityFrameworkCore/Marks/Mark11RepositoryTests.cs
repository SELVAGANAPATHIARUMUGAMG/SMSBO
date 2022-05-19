using System;
using System.Threading.Tasks;
using SMSBO.Marks;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Marks
{
    public class Mark11RepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IMark11Repository _mark11Repository;

        public Mark11RepositoryTests()
        {
            _mark11Repository = GetRequiredService<IMark11Repository>();
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
