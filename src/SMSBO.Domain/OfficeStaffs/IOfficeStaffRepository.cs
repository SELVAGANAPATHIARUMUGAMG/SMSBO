using System;
using Volo.Abp.Domain.Repositories;

namespace SMSBO.OfficeStaffs
{
    public interface IOfficeStaffRepository : IRepository<OfficeStaff, Guid>
    {
    }
}