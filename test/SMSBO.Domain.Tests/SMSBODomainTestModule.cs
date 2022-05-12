using SMSBO.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SMSBO;

[DependsOn(
    typeof(SMSBOEntityFrameworkCoreTestModule)
    )]
public class SMSBODomainTestModule : AbpModule
{

}
