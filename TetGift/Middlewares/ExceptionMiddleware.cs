using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Text.Json;

namespace TetGift.Middlewares
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

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var (status, message) = Map(ex);

                if (status >= 500) _logger.LogError(ex, "Unhandled exception");
                else _logger.LogWarning(ex, "Handled exception");

                context.Response.StatusCode = status;
                context.Response.ContentType = "application/json";

                var json = JsonSerializer.Serialize(new { message });
                await context.Response.WriteAsync(json);
            }
        }

        private static (int status, string message) Map(Exception ex)
        {
            var root = ex;
            while (root.InnerException != null && (root is AggregateException || root is DbUpdateException))
                root = root.InnerException;

            if (root is PostgresException pg)
            {
                if (pg.SqlState == "23505")
                    return (409, "Dữ liệu bị trùng (unique constraint).");

                return (400, pg.MessageText ?? "Database error.");
            }

            if (ex is DbUpdateException)
                return (400, "Database update failed.");

            if (ex is UnauthorizedAccessException)
                return (401, "Unauthorized.");

            if (root is FileNotFoundException || root is DirectoryNotFoundException)
                return (500, root.Message);

            return (400, ex.Message);
        }
    }
}
