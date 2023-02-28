using CoreWeb.Core.Services;
using CoreWeb.Data;
using CoreWeb.Data.IRepositories;
using CoreWeb.Data.Repositories;
using CoreWeb.Interface.Services;
using Microsoft.AspNetCore.Builder;

namespace CoreWeb.Core.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            services.AddControllersWithViews();
            services.AddServices(configuration);
            services.AddDbContext<DataContext>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IClass, Class>();
            //services.AddSingleton(xxx);
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }

        public static IApplicationBuilder ConfigureServer(this IApplicationBuilder app, IConfiguration config, IWebHostEnvironment env)
        {

            // Configure the HTTP request pipeline.
            if (!env.IsDevelopment())
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            //app.UseAuthorization();
            //app.UseAuthentication();

            //app.UseMiddleware(typeof(MiddlewareType));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller}/{action=Index}/{id?}");
                endpoints.MapFallbackToFile("index.html");
            });

            return app;
        }
    }
}
