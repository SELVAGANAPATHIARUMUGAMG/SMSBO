using SMSBO.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SMSBO.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SMSBOPageModel : AbpPageModel
{
    protected SMSBOPageModel()
    {
        LocalizationResourceType = typeof(SMSBOResource);
    }
}
