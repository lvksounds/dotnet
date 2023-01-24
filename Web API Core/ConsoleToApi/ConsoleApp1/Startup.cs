using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Esse veio do USE 1 - 1\n");
            //    await next();
            //    await context.Response.WriteAsync("Esse veio do USE 1 - 2\n");
            //});

            //app.UseMiddleware<CustomMiddleware1>();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Esse veio do USE 2 - 1\n");
            //    await next();
            //    await context.Response.WriteAsync("Esse veio do USE 2 - 2\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request completa!\n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Esse veio do RUN\n");
            //});

            //app.Map("/nitish", CustomCode);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Esse veio do NITISH \n");
            });
        }
    }
}
