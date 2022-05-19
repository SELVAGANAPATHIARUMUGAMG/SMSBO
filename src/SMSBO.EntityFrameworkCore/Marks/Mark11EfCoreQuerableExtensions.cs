using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.Marks
{
    public static class Mark11EfCoreQueryableExtensions
    {
        public static IQueryable<Mark11> IncludeDetails(this IQueryable<Mark11> queryable, bool include = true)
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