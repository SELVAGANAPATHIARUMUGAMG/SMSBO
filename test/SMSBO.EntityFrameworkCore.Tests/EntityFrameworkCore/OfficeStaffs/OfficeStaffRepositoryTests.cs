using System;
using System.Threading.Tasks;
using SMSBO.OfficeStaffs;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SMSBO.EntityFrameworkCore.OfficeStaffs
{
    public class OfficeStaffRepositoryTests : SMSBOEntityFrameworkCoreTestBase
    {
        private readonly IOfficeStaffRepository _officeStaffRepository;

        public OfficeStaffRepositoryTests()
        {
            _officeStaffRepository = GetRequiredService<IOfficeStaffRepository>();
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
