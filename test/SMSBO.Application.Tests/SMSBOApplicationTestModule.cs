using Volo.Abp.Modularity;

namespace SMSBO;

[DependsOn(
    typeof(SMSBOApplicationModule),
    typeof(SMSBODomainTestModule)
    )]
public class SMSBOApplicationTestModule : AbpModule
{

}
