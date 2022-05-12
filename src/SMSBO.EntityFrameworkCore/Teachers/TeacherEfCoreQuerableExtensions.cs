using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.Teachers
{
    public static class TeacherEfCoreQueryableExtensions
    {
        public static IQueryable<Teacher> IncludeDetails(this IQueryable<Teacher> queryable, bool include = true)
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