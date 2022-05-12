using SMSBO.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SMSBO.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SMSBOController : AbpControllerBase
{
    protected SMSBOController()
    {
        LocalizationResource = typeof(SMSBOResource);
    }
}
