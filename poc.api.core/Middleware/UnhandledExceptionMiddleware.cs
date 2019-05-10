using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WebInterface.Middleware
{
    public class UnhandledExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<UnhandledExceptionMiddleware> _logger;

        public UnhandledExceptionMiddleware(RequestDelegate next, ILogger<UnhandledExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            /*
             Adiciona aqui suas exceptions customizadas para fazer um tratamento diferenciado
            catch (CustomException ex)
            {
                await WriteErrorResult(httpContext, HttpStatusCode.OK, ex);
            }
            */
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                await WriteErrorResult(httpContext, HttpStatusCode.InternalServerError, ex);
            }
        }

        private static async Task WriteErrorResult(HttpContext httpContext, HttpStatusCode statusCode, Exception exception)
        {
            var result = new
            {
                StatusCode = (int)statusCode,
                Message = exception.InnerException?.Message ?? exception.Message
            };

            httpContext.Response.StatusCode = result.StatusCode;

            httpContext.Response.ContentType = "application/json";

            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }
    }
}