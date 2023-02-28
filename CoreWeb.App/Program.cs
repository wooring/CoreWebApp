using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CoreWeb.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                              .ConfigureWebHostDefaults(builder =>
                              {
                                  builder.UseStartup<Startup>();
                              })
                              .ConfigureAppConfiguration((app, config) =>
                              {
                                  config.AddXmlFile("appsettings.xml", optional: true, reloadOnChange: true);
                              })
                              .ConfigureLogging(logging =>
                              {
                                  logging.SetMinimumLevel(LogLevel.Warning);
                              });
        }
    }
}

