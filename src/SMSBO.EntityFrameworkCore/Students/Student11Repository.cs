using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Students
{
    public class Student11Repository : EfCoreRepository<SMSBODbContext, Student11, Guid>, IStudent11Repository
    {
        public Student11Repository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}