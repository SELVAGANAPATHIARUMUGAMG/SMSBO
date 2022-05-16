using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.Students
{
    public static class Student12EfCoreQueryableExtensions
    {
        public static IQueryable<Student12> IncludeDetails(this IQueryable<Student12> queryable, bool include = true)
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