using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SMSBO.Data;
using Volo.Abp.DependencyInjection;

namespace SMSBO.EntityFrameworkCore;

public class EntityFrameworkCoreSMSBODbSchemaMigrator
    : ISMSBODbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSMSBODbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SMSBODbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SMSBODbContext>()
            .Database
            .MigrateAsync();
    }
}
