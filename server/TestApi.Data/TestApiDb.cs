using Microsoft.EntityFrameworkCore;
using System.Linq;
using TestApi.Domain.Domain;

namespace TestApi.Data
{
    public class TestApiDb : DbContext
    {
        public TestApiDb(DbContextOptions<TestApiDb> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public void Seed()
        {
            if (Products.Any()) return;

            DataStore.GetProducts().ForEach(p => Products.Add(p));

            SaveChanges();
        }
    }
}
