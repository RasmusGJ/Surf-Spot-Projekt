using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surf_spotter_dot_net_core.Models.Middlewares
{
    public class ConverterMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ConverterMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;
            _logger = logFactory.CreateLogger("MyMiddleware");
        }
        public async Task Invoke(HttpContext httpContext)
        {
            
        }
    }
    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConverterMiddleware>();
        }
    }
}

