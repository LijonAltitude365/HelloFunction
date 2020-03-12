using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

[assembly: FunctionsStartup(typeof(Altitude_Azure_Function_Graph_EF1.Startup))]

namespace Altitude_Azure_Function_Graph_EF1
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<ServiceContracts.IHelloWorld, Repositories.HelloWorld>();
            builder.Services.AddLogging();

            builder.Services.AddOptions<Settings.ApplicationSettings>()
           .Configure<IConfiguration>((settings, configuration) =>
           {
               configuration.Bind(settings);
           });
        }
    }
}
