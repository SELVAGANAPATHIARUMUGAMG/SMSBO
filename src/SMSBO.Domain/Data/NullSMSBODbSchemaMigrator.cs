using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SMSBO.Data;

/* This is used if database provider does't define
 * ISMSBODbSchemaMigrator implementation.
 */
public class NullSMSBODbSchemaMigrator : ISMSBODbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
