using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Students
{
    public class StudentRepository : EfCoreRepository<SMSBODbContext, Student, Guid>, IStudentRepository
    {
        public StudentRepository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}