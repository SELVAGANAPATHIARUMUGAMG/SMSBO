using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.Marks
{
    public static class MarkEfCoreQueryableExtensions
    {
        public static IQueryable<Mark> IncludeDetails(this IQueryable<Mark> queryable, bool include = true)
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