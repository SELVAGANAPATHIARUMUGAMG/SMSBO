using System;
using System.Threading.Tasks;
using SMSBO.Marks;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Marks
{
    public class Mark12RepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IMark12Repository _mark12Repository;

        public Mark12RepositoryTests()
        {
            _mark12Repository = GetRequiredService<IMark12Repository>();
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
