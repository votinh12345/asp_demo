using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace hienv_asp.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareRequest
    {
        private readonly RequestDelegate _next;

        private readonly ILogger _logger;
        public MiddlewareRequest(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<MiddlewareRequest>();
        }

        public Task Invoke(HttpContext httpContext)
        {
            var pathBase = httpContext.Request.PathBase;
            _logger.LogInformation("Request {method} {url} => {statusCode}",
                    httpContext.Request?.Method,
                    httpContext.Request?.Path.Value,
                    httpContext.Response?.StatusCode);
            var pages = httpContext.Request.Path.Value;
            httpContext.Items.Add("pages", pages);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareRequestExtensions
    {
        public static IApplicationBuilder UseMiddlewareRequest(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareRequest>();
        }
    }
}
