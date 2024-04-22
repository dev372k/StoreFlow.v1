using API.Models;
using Shared.Exceptions;

namespace API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (CustomException ex)
            {
                context.Response.StatusCode = ex.Model.StatusCode;
                _logger.LogError($"Error Message: {ex}\n Error Detail: {ex.InnerException?.ToString()}");
                await context.Response.WriteAsJsonAsync(new ResponseModel()
                {
                    Status = false,
                    StatusCode = context.Response.StatusCode,
                    Message = context.Response.StatusCode == StatusCodes.Status200OK ? ex.Message : "Internal Server Error.",
                });
            }
        }
    }
}

