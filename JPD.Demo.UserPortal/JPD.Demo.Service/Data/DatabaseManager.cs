using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace JPD.Demo.Service.Data
{
    public static class DatabaseManager
    {
        public static IWebHost CreateDatabase(this IWebHost webHost, bool deleteIfExists)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                using (var userContext = scope.ServiceProvider.GetRequiredService<UserContext>())
                {
                    try
                    {
                        if (deleteIfExists)
                        {
                            userContext.Database.EnsureDeleted();
                        }
                    }
                    catch (Exception)
                    {
                        // Might not have appropriate permissions. Just use the existing database.
                        // TODO: Log the error. 
                    }

                    userContext.Database.EnsureCreated();
                }
            }
            return webHost;
        }
    }
}
