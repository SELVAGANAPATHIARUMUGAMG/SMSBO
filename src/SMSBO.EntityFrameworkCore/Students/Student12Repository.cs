using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Students
{
    public class Student12Repository : EfCoreRepository<SMSBODbContext, Student12, Guid>, IStudent12Repository
    {
        public Student12Repository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}