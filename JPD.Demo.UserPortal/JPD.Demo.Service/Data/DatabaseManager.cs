using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace JPD.Demo.Service.Data
{
    public static class DatabaseManager
    {
        public static IWebHost CreateDatabase(this IWebHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                using (var userContext = scope.ServiceProvider.GetRequiredService<UserContext>())
                {
                    try
                    {
                        userContext.Database.EnsureCreated();
                    }
                    catch (Exception)
                    {
                        // TODO: Log the error
                        throw;
                    }
                }
            }
            return webHost;
        }
    }
}
