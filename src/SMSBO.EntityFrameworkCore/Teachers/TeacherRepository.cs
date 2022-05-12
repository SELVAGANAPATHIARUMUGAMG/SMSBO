using System;
using SMSBO.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SMSBO.Teachers
{
    public class TeacherRepository : EfCoreRepository<SMSBODbContext, Teacher, Guid>, ITeacherRepository
    {
        public TeacherRepository(IDbContextProvider<SMSBODbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}