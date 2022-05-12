using SMSBO.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SMSBO.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SMSBOEntityFrameworkCoreModule),
    typeof(SMSBOApplicationContractsModule)
    )]
public class SMSBODbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
