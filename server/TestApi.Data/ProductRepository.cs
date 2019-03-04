using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestApi.Domain.Domain;

namespace TestApi.Data
{
    public class ProductRepository
    {
        private readonly TestApiDb _db;
        private readonly DbSet<Product> _table;

        public ProductRepository(TestApiDb db)
        {
            _db = db;
            _table = db.Set<Product>();
        }

        public async Task<IEnumerable<Product>> All()
        {
            return await _table.ToListAsync();
        }
    }
}
