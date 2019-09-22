using JPD.Demo.Service.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace JPD.Demo.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build()
                .CreateDatabase(deleteIfExists:true)
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
