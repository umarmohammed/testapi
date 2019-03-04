using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestApi.Domain;
using TestApi.Domain.Domain;

namespace TestApi.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("~/v1/products")]
        public ActionResult<IList<Product>> GetProducts()
        {
            return DataStore.GetProducts();
        }
    }
}