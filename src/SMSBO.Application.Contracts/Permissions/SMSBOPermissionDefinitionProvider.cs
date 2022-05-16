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

            var officeStaffPermission = myGroup.AddPermission(SMSBOPermissions.OfficeStaff.Default, L("Permission:OfficeStaff"));
            officeStaffPermission.AddChild(SMSBOPermissions.OfficeStaff.Create, L("Permission:Create"));
            officeStaffPermission.AddChild(SMSBOPermissions.OfficeStaff.Update, L("Permission:Update"));
            officeStaffPermission.AddChild(SMSBOPermissions.OfficeStaff.Delete, L("Permission:Delete"));

            var vehicledetailPermission = myGroup.AddPermission(SMSBOPermissions.Vehicledetail.Default, L("Permission:Vehicledetail"));
            vehicledetailPermission.AddChild(SMSBOPermissions.Vehicledetail.Create, L("Permission:Create"));
            vehicledetailPermission.AddChild(SMSBOPermissions.Vehicledetail.Update, L("Permission:Update"));
            vehicledetailPermission.AddChild(SMSBOPermissions.Vehicledetail.Delete, L("Permission:Delete"));

            var studentPermission = myGroup.AddPermission(SMSBOPermissions.Student.Default, L("Permission:Student"));
            studentPermission.AddChild(SMSBOPermissions.Student.Create, L("Permission:Create"));
            studentPermission.AddChild(SMSBOPermissions.Student.Update, L("Permission:Update"));
            studentPermission.AddChild(SMSBOPermissions.Student.Delete, L("Permission:Delete"));

            var student11Permission = myGroup.AddPermission(SMSBOPermissions.Student11.Default, L("Permission:Student11"));
            student11Permission.AddChild(SMSBOPermissions.Student11.Create, L("Permission:Create"));
            student11Permission.AddChild(SMSBOPermissions.Student11.Update, L("Permission:Update"));
            student11Permission.AddChild(SMSBOPermissions.Student11.Delete, L("Permission:Delete"));

            var student12Permission = myGroup.AddPermission(SMSBOPermissions.Student12.Default, L("Permission:Student12"));
            student12Permission.AddChild(SMSBOPermissions.Student12.Create, L("Permission:Create"));
            student12Permission.AddChild(SMSBOPermissions.Student12.Update, L("Permission:Update"));
            student12Permission.AddChild(SMSBOPermissions.Student12.Delete, L("Permission:Delete"));

            
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SMSBOResource>(name);
    }
}
