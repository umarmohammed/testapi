using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestApi.Data;

namespace TestApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddMvcWithCompatibilityVersion(this IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public static void AddDbContextWithSqlServer(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<TestApiDb>(options => options.UseSqlServer(connectionString));
        }

        public static void AddPerRequestInjections(this IServiceCollection services)
        {
            services.AddScoped<ProductRepository>();
        }
    }
}
