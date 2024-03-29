using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCTest2.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCTest2
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
            // services.AddSingleton<IData, Data>(); // Step 6: Add Singleton to services
            services.AddScoped<IData, DBData>();
            // services.AddDbContext<EmployeeContext>(options => options.UseSqlite("Data Source=Employees.db"));
            services.AddDbContext<EmployeeContext>(options => options.UseSqlServer("Server=DESKTOP-N3H4L3V;Database=MSSAEmployees;Trusted_Connection=True;MultipleActiveResultSets=True"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, EmployeeContext employeeContext)
        {
            //employeeContext.Database.EnsureDeleted();
            employeeContext.Database.EnsureCreated();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
