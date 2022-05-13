using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.OfficeStaffs
{
    public static class OfficeStaffEfCoreQueryableExtensions
    {
        public static IQueryable<OfficeStaff> IncludeDetails(this IQueryable<OfficeStaff> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}