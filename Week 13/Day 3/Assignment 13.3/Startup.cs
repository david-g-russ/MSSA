using Assignment_13._3.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Assignment_13._3
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
            //services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddScoped<IProductRepository, DBRepository>();
            services.AddDbContext<ProductContext>(options => options.UseSqlServer("Server = DESKTOP-N3H4L3V; Database = Products; Trusted_Connection = True; MultipleActiveResultSets = True"));
            services.AddIdentity<User, IdentityRole>(options =>
             {
                 options.Password.RequiredLength = 8;
                 options.Password.RequireUppercase = true;
                 options.Password.RequireLowercase = true;
                 options.Password.RequireDigit = true;
                 options.Password.RequireNonAlphanumeric = true;
             }).AddEntityFrameworkStores<UserContext>();
            services.AddDbContext<UserContext>(options => options.UseSqlServer("Server = DESKTOP-N3H4L3V; Database = Users; Trusted_Connection = True; MultipleActiveResultSets = True"));
        }

        public async void CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            string[] rolenames = { "Admin", "Customer" };
            foreach (var rolename in rolenames)
            {
                bool roleExists = await roleManager.RoleExistsAsync(rolename);
                if (!roleExists)
                {
                    IdentityRole role = new();
                    role.Name = rolename;
                    await roleManager.CreateAsync(role);
                }
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ProductContext productContext, UserContext userContext, RoleManager<IdentityRole> roleManager)
        {
            productContext.Database.EnsureCreated();
            userContext.Database.EnsureCreated();
            CreateRoles(roleManager);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseAuthentication();

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