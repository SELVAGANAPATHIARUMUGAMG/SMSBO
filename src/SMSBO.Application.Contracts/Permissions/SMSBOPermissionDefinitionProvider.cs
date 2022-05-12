using SMSBO.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SMSBO.Permissions;

public class SMSBOPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SMSBOPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SMSBOPermissions.MyPermission1, L("Permission:MyPermission1"));

            var teacherPermission = myGroup.AddPermission(SMSBOPermissions.Teacher.Default, L("Permission:Teacher"));
            teacherPermission.AddChild(SMSBOPermissions.Teacher.Create, L("Permission:Create"));
            teacherPermission.AddChild(SMSBOPermissions.Teacher.Update, L("Permission:Update"));
            teacherPermission.AddChild(SMSBOPermissions.Teacher.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SMSBOResource>(name);
    }
}
