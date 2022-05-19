using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using SMSBO.Teachers;
using Volo.Abp.EntityFrameworkCore.Modeling;
using SMSBO.OfficeStaffs;
using SMSBO.Vehicledetails;
using SMSBO.Students;
using SMSBO.Marks;


namespace SMSBO.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class SMSBODbContext :
    AbpDbContext<SMSBODbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<OfficeStaff> OfficeStaffs { get; set; }
        public DbSet<Vehicledetail> Vehicledetails { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student11> Student11s { get; set; }
        public DbSet<Student12> Student12s { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Mark11> Mark11s { get; set; }
        public DbSet<Mark12> Mark12s { get; set; }

    public SMSBODbContext(DbContextOptions<SMSBODbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(SMSBOConsts.DbTablePrefix + "YourEntities", SMSBOConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});


            builder.Entity<Teacher>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Teachers", SMSBOConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<OfficeStaff>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "OfficeStaffs", SMSBOConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Vehicledetail>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Vehicledetails", SMSBOConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Student>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Students", SMSBOConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Student11>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Student11s", SMSBOConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Student12>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Student12s", SMSBOConsts.DbSchema);
                b.ConfigureByConvention();


                /* Configure more properties here */
            });


            builder.Entity<Mark>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Marks", SMSBOConsts.DbSchema);
                b.ConfigureByConvention();

                /* Configure more properties here */
                //b.HasOne<Student>().WithMany().HasForeignKey(x => x.StudentId).IsRequired();

            });


            builder.Entity<Mark11>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Mark11s", SMSBOConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Mark12>(b =>
            {
                b.ToTable(SMSBOConsts.DbTablePrefix + "Mark12s", SMSBOConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
    }
}
