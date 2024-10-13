using Application.Contracts.Helpers;
using Microsoft.AspNetCore.Http;

namespace Application.Middlewares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDbLogger _logger;

        public LogMiddleware(RequestDelegate next, IDbLogger logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            // Capture the response body
            var originalBodyStream = context.Response.Body;
            using var responseBodyStream = new MemoryStream();
            context.Response.Body = responseBodyStream;

            try
            {
                // Call the next middleware
                await _next(context);

                // Read the response body
                responseBodyStream.Seek(0, SeekOrigin.Begin);
                var responseBody = await new StreamReader(responseBodyStream).ReadToEndAsync();

                await _logger.Log(context.Response.StatusCode, context.Request.Path, "", context.Request.QueryString.ToString(), responseBody);

                responseBodyStream.Seek(0, SeekOrigin.Begin);
                await responseBodyStream.CopyToAsync(originalBodyStream);
            }
            finally
            {
                context.Response.Body = originalBodyStream;
            }
        }
    }
}
