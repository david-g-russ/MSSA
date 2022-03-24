using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomMiddleware.Services;

namespace CustomMiddleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // registering custom services

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddTransient<IRandomService, RandomService>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // serves Default.html as landing page
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("Default.html");
            // app.UseDefaultFiles(defaultFilesOptions);

            app.UseStaticFiles(); // allow wwwroot folder
            app.UseStaticFiles(new StaticFileOptions() // allow Staticfiles folder
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"Staticfiles")),RequestPath="/Static"
            });

            app.UseRouting();

            app.UseMvcWithDefaultRoute();

            // custom middleware: custom logic related to logging, setup culture

            app.Use(async (context, next) => 
            {
                // logic
                await context.Response.WriteAsync("Entered first custom middleware");
                await next(); // passing control to next middleware
                await context.Response.WriteAsync("Leaving first custom middleware");
            });

            app.Use(async (context, next) =>
            {
                // logic
                await context.Response.WriteAsync("Entered second custom middleware");
                await next(); // passing control to next middleware
                await context.Response.WriteAsync("Leaving second custom middleware");
            });

            // terminal middleware
            app.Run(async (context) =>
            {
                // logic
                await context.Response.WriteAsync("Entered final custom middleware");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
