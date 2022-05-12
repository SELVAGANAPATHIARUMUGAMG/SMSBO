using Volo.Abp.Settings;

namespace SMSBO.Settings;

public class SMSBOSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SMSBOSettings.MySetting1));
    }
}
