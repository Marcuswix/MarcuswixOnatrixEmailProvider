using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Azure.Communication.Email;
using Microsoft.Extensions.Configuration;

[assembly: FunctionsStartup(typeof(MyNamespace.Startup))]

namespace MyNamespace
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            // Registrera EmailClient som en Singleton
            builder.Services.AddSingleton<EmailClient>(provider =>
            {
                var configuration = provider.GetRequiredService<IConfiguration>();
                var connectionString = configuration["CommunicationServices"];
                return new EmailClient(connectionString);
            });

            // Lägg till andra tjänster om det behövs
        }
    }
}

