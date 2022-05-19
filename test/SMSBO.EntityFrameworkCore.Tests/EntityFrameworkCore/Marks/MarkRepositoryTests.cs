using System;
using System.Threading.Tasks;
using SMSBO.Marks;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.Marks
{
    public class MarkRepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IMarkRepository _markRepository;

        public MarkRepositoryTests()
        {
            _markRepository = GetRequiredService<IMarkRepository>();
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
