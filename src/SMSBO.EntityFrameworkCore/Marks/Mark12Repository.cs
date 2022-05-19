using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Marks
{
    public class Mark12Repository : EfCoreRepository<SMSBODbContext, Mark12, Guid>, IMark12Repository
    {
        public Mark12Repository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}