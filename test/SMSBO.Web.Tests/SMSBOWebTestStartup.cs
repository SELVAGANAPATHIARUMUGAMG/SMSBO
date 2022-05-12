using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace SMSBO;

public class SMSBOWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<SMSBOWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
