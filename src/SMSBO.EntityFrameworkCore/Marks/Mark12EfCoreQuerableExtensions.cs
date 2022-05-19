using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.Marks
{
    public static class Mark12EfCoreQueryableExtensions
    {
        public static IQueryable<Mark12> IncludeDetails(this IQueryable<Mark12> queryable, bool include = true)
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