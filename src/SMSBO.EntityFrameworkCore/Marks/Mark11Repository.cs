using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Marks
{
    public class Mark11Repository : EfCoreRepository<SMSBODbContext, Mark11, Guid>, IMark11Repository
    {
        public Mark11Repository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}