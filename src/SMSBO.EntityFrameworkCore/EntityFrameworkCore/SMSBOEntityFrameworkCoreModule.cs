using SMSBO.Marks;
using SMSBO.Students;
using SMSBO.Vehicledetails;
using SMSBO.OfficeStaffs;
using SMSBO.Teachers;
using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace SMSBO.EntityFrameworkCore;

[DependsOn(
    typeof(SMSBODomainModule),
    typeof(AbpIdentityEntityFrameworkCoreModule),
    typeof(AbpIdentityServerEntityFrameworkCoreModule),
    typeof(AbpPermissionManagementEntityFrameworkCoreModule),
    typeof(AbpSettingManagementEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule),
    typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
    typeof(AbpAuditLoggingEntityFrameworkCoreModule),
    typeof(AbpTenantManagementEntityFrameworkCoreModule),
    typeof(AbpFeatureManagementEntityFrameworkCoreModule)
    )]
public class SMSBOEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        SMSBOEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<SMSBODbContext>(options =>
        {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
                options.AddRepository<Teacher, TeacherRepository>();
                options.AddRepository<OfficeStaff, OfficeStaffRepository>();
                options.AddRepository<Vehicledetail, VehicledetailRepository>();
                options.AddRepository<Student, StudentRepository>();
                options.AddRepository<Student11, Student11Repository>();
                options.AddRepository<Student12, Student12Repository>();
                options.AddRepository<Mark, MarkRepository>();
                options.AddRepository<Mark11, Mark11Repository>();
                options.AddRepository<Mark12, Mark12Repository>();
        });

        Configure<AbpDbContextOptions>(options =>
        {
                /* The main point to change your DBMS.
                 * See also SMSBOMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });
    }
}
