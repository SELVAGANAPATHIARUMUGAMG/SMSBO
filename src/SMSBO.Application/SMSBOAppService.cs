using System;
using System.Collections.Generic;
using System.Text;
using SMSBO.Localization;
using Volo.Abp.Application.Services;

namespace SMSBO;

/* Inherit your application services from this class.
 */
public abstract class SMSBOAppService : ApplicationService
{
    protected SMSBOAppService()
    {
        LocalizationResource = typeof(SMSBOResource);
    }
}
