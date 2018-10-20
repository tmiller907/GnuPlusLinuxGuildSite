using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using GnuPlusLinuxDAL;

namespace GnuPlusLinux
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost build = BuildWebHost(args);

            using (IServiceScope scope = build.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;

                try
                {
                    AccountContext context = services
                        .GetRequiredService<AccountContext>();

                    AccountDatabaseInitializer.Seed(context);
                }
                catch (Exception ex)
                {
                    ILogger logger = services
                        .GetRequiredService<ILogger<Program>>();

                    logger.LogError(ex,
                        "An error occurred seeding the database.");
                }
            }

            build.Run();
        }

        private static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}
