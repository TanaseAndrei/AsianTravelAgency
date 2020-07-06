using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsianTravelAgency.Interfaces;
using AsianTravelAgency.Repositories;
using AsianTravelAgency.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AsianTravelAgency
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=TestEntityFrameworkDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<AsianTravelAgencyContext>
                (options => options.UseSqlServer(connection));

            //add the services, a service is a dependent class
            //the repositories are services too
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPricesRepository, PricesRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPicturesRepository, PicturesRepository>();
            services.AddScoped<IFAQRepository, FAQRepository>();
            services.AddScoped<IAboutUsPostRepository, AboutUsPostRepository>();

            //add the services
            services.AddScoped<PostService>();
            services.AddScoped<UserService>();
            services.AddScoped<PricesService>();
            services.AddScoped<PicturesService>();
            services.AddScoped<FAQService>();
            services.AddScoped<AboutUsPostService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
