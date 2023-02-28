//using Microsoft.Extensions.Logging;
//using CoreWeb.Core.Extensions;
//using Microsoft.Extensions.Configuration;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using Microsoft.AspNetCore.Builder;

//namespace CoreWeb.Api
//{
//    public class Startup
//    {
//        public IConfiguration Configuration { get; }
//        public IWebHostEnvironment Environment { get; }

//        public Startup(IConfiguration config, IWebHostEnvironment environment)
//        {
//            Configuration = config;
//            Environment = environment;
//        }

//        public void ConfigureServices(IServiceCollection services)
//        {
//            //services.AddMvc();
//            services.ConfigureServices(this.Configuration, this.Environment);
//        }

//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
//        {
//            app.ConfigureServer(this.Configuration, env);

//            var log = serviceProvider.GetService<ILogger<Startup>>();
//            log.LogInformation("Started web host");
//        }
//    }
//}
