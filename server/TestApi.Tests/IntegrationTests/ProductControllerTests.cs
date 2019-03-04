﻿using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestApi.Dto;
using Xunit;

namespace TestApi.Tests.IntegrationTests
{
    public class ProductControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ProductControllerTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_ProductsReturnsSuccess()
        {
            var response = await _client.GetAsync("/v1/products");

            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Get_ProductsReturnsCorrectProducts()
        {
            var response = await _client.GetAsync("/v1/products");
            var resultString = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(resultString);

            Assert.Equal(5, products.Count());
        }
    }
}