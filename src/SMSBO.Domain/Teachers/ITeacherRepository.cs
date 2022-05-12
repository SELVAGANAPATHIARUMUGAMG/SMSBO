using System;
using Volo.Abp.Domain.Repositories;

namespace SMSBO.Teachers
{
    public interface ITeacherRepository : IRepository<Teacher, Guid>
    {
    }
}