using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.Students
{
    public static class Student11EfCoreQueryableExtensions
    {
        public static IQueryable<Student11> IncludeDetails(this IQueryable<Student11> queryable, bool include = true)
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