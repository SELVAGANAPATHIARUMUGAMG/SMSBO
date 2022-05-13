using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SMSBO.Vehicledetails
{
    public static class VehicledetailEfCoreQueryableExtensions
    {
        public static IQueryable<Vehicledetail> IncludeDetails(this IQueryable<Vehicledetail> queryable, bool include = true)
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