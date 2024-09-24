using Azure.Communication.Email;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(OnatrixEmailProvider.Startup))]

namespace OnatrixEmailProvider
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton(new EmailClient(Environment.GetEnvironmentVariable("CommunicationServices")));
        }
    }
}
