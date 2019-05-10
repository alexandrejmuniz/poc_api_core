using Microsoft.AspNetCore.Builder;

namespace WebInterface.Middleware
{
    public static class UnhandledExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseUnhandledExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UnhandledExceptionMiddleware>();
        }
    }
}