using System;
using Volo.Abp.Domain.Repositories;

namespace SMSBO.Students
{
    public interface IStudentRepository : IRepository<Student, Guid>
    {
    }
}