using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.OfficeStaffs
{
    public class OfficeStaffRepository : EfCoreRepository<SMSBODbContext, OfficeStaff, Guid>, IOfficeStaffRepository
    {
        public OfficeStaffRepository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}