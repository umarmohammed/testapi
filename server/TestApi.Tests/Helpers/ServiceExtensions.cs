using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestApi.Data;

namespace TestApi.Tests.Helpers
{
    public static class ServiceExtensions
    {
        public static void AddDbContextInMemory(this IServiceCollection services, ServiceProvider serviceProvider)
        {
            services.AddDbContext<TestApiDb>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDbForTesting");
                options.UseInternalServiceProvider(serviceProvider);
            });
        }
    }
}
