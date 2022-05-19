using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Marks
{
    public class MarkRepository : EfCoreRepository<SMSBODbContext, Mark, Guid>, IMarkRepository
    {
        public MarkRepository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}