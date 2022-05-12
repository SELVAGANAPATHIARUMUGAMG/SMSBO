using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SMSBO.Web;

[Dependency(ReplaceServices = true)]
public class SMSBOBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SMSBO";
}
