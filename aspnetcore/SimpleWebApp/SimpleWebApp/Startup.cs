using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SimpleWebApp.Controllers;
using SimpleWebApp.Services;
using SimpleWebApp.Middleware;

namespace SimpleWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreetingService, GreetingService>();
            services.AddTransient<MyController>();
            services.AddSession();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseMyCustomMiddleware();
            app.UseStaticFiles();
            app.UseSession();

            app.MapWhen(context =>
            {
                return context.Request.Path.Value.Contains("one");
            }, app1 =>
            {
                app1.Run(async context =>
                {
                    await context.Response.WriteAsync("<h1>one is in the path</h1>");
                });
            });

            app.Map("/session", sessionApp =>
            {
                sessionApp.Run(async context =>
                {
                    await SessionSample.SessionAsync(context);
                });
            });

            app.Map("/hello", app1 =>
            {
                app1.Run(async context =>
                {
                    var controller = app1.ApplicationServices.GetService<MyController>();
                    string response = controller.Index("Katharina");
                    await context.Response.WriteAsync($"<div>{response}</div>");
                });
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>Hello World!</h1>");
            });
        }
    }
}
