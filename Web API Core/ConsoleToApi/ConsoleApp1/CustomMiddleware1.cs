using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Esse veio do novo arquivo 1\n");
            await next(context);
            await context.Response.WriteAsync("Esse veio do novo arquivo 2\n");
        }
    }
}
