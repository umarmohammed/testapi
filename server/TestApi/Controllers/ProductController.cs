using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Data;
using TestApi.Domain.Domain;

namespace TestApi.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("~/v1/products")]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.All();
        }
    }
}