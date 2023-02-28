//using Microsoft.AspNetCore;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;

//namespace CoreWeb.Api
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateWebHostBuilder(args).Run();
//        }

//        public static IWebHost CreateWebHostBuilder(string[] args)
//        {
//            var builder = WebHost.CreateDefaultBuilder(args)
//                            .UseStartup<Startup>()
//                            .ConfigureAppConfiguration((app, config) =>
//                            {
//                                config.AddXmlFile("appsettings.xml", optional: true, reloadOnChange: true);
//                            })
//                            .ConfigureLogging(logging => 
//                            {
//                                logging.SetMinimumLevel(LogLevel.Warning); 
//                            });

//            return builder.Build();
//        }
//    }
//}

