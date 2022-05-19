using System;
using Volo.Abp.Domain.Repositories;

namespace SMSBO.Marks
{
    public interface IMarkRepository : IRepository<Mark, Guid>
    {
    }
}