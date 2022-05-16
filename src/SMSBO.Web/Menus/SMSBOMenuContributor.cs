using System.Threading.Tasks;
using SMSBO.Permissions;
using SMSBO.Localization;
using SMSBO.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace SMSBO.Web.Menus;

public class SMSBOMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<SMSBOResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                SMSBOMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            ));
        var student = new ApplicationMenuItem(
            "Student",
            l["Students"],
            icon: "fas fa-user-graduate"
        );

        context.Menu.AddItem(student);
        if (await context.IsGrantedAsync(SMSBOPermissions.Student.Default))
        {
            student.AddItem(new ApplicationMenuItem(
              "Student.Student",
              l["Class X"],
              icon: "fas fa-chalkboard-teacher",
             url: "/Students/Student"
         ));
        }
        if (await context.IsGrantedAsync(SMSBOPermissions.Student11.Default))
        {
            student.AddItem(new ApplicationMenuItem(
                "Student.Student11",
                l["Class XI"],
                icon: "fas fa-chalkboard-teacher",
               url: "/Students/Student11"
           ));
        }
        if (await context.IsGrantedAsync(SMSBOPermissions.Student12.Default))
        {
            student.AddItem(new ApplicationMenuItem(
                "Student.Student12",
                l["Class XII"],
                icon: "fas fa-chalkboard-teacher",
               url: "/Students/Student12"
           ));
        }

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
            if (await context.IsGrantedAsync(SMSBOPermissions.Teacher.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        SMSBOMenus.Teacher, 
                        l["Teacher"],  
                        url:"/Teachers/Teacher",
                        icon: "fas fa-users")
                );
            }
            if (await context.IsGrantedAsync(SMSBOPermissions.OfficeStaff.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        SMSBOMenus.OfficeStaff, 
                        l["OfficeStaff"], 
                        url:"/OfficeStaffs/OfficeStaff",
                        icon: "fas fa-users"
                        )
                );
            }
            if (await context.IsGrantedAsync(SMSBOPermissions.Vehicledetail.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(
                        SMSBOMenus.Vehicledetail,
                        l["Vehicledetail"], 
                        url:"/Vehicledetails/Vehicledetail",
                        icon: "fas fa-bus")
                );
            }
         
    }
}
