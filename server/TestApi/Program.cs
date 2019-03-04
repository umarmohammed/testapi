using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TestApi.Data;

namespace TestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            ProcessDbCommands(args, host);
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void ProcessDbCommands(string[] args, IWebHost host)
        {
            var services = (IServiceScopeFactory)host.Services.GetService(typeof(IServiceScopeFactory));
            using (var scope = services.CreateScope())
            {
                if (args.Contains("dropdb"))
                {
                    Console.WriteLine("Dropping database");
                    var db = GetTestApiDb(scope);
                    db.Database.EnsureDeleted();
                }
                if (args.Contains("migratedb"))
                {
                    Console.WriteLine("Migrating database");
                    var db = GetTestApiDb(scope);
                    db.Database.Migrate();
                }
                if (args.Contains("seeddb"))
                {
                    Console.WriteLine("Seeding database");
                    var db = GetTestApiDb(scope);
                    db.Seed();
                }
            }

            if (args.Contains("stop"))
            {
                Console.WriteLine("Exiting on stop command");
                Environment.Exit(0);
            }
        }

        private static TestApiDb GetTestApiDb(IServiceScope scope)
        {
            return scope.ServiceProvider.GetRequiredService<TestApiDb>();
        }
    }
}
