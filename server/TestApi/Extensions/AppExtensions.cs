using Microsoft.AspNetCore.Builder;

namespace TestApi.Extensions
{
    public static class AppExtensions
    {
        public static void AddCorsAllowAny(this IApplicationBuilder app)
        {
            app.UseCors(options =>
            {
                options.AllowAnyHeader();
                options.AllowAnyMethod();
                options.AllowAnyOrigin();
            });
        }
    }
}
