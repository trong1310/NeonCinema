using System.Collections.Concurrent;

namespace NeonCinema_API.Controllers.Service
{
    public class TokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        public static readonly ConcurrentDictionary<string, DateTime> RevokedTokens = new();

        public TokenValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/api/Login/Login", StringComparison.OrdinalIgnoreCase))
            {
                await _next(context);
                return;
            }
            var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (!string.IsNullOrEmpty(token))
            {
                if (RevokedTokens.ContainsKey(token))
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("Token đã bị thu hồi. Vui lòng đăng nhập lại.");
                    return;
                }
            }
            await _next(context);
        }

        public static void RevokeToken(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                // Thêm token vào danh sách bị thu hồi
                RevokedTokens.TryAdd(token, DateTime.UtcNow);
            }
        }

        public static void RemoveToken(string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                // Xóa token khỏi danh sách thu hồi khi người dùng đăng nhập lại
                RevokedTokens.TryRemove(token, out _);
            }
        }
    }
}
