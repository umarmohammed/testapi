using System.Collections.Generic;
using TestApi.Data;
using TestApi.Domain.Domain;

namespace TestApi.Tests.Helpers
{
    public static class Utilities
    {
        public static void InitializeDbForTests(TestApiDb db)
        {
            db.Products.AddRange(GetSeedingMessages());
            db.SaveChanges();
        }

        public static List<Product> GetSeedingMessages()
        {
            return new List<Product>
            {
                {new Product { Id = 1, ModelCode = "SM-S8ABCD13", ProductName = "Galaxy S3", SerialNumber = "SN00000001" }},
                {new Product { Id = 2,  ModelCode = "SM-S8ABCD17", ProductName = "Galaxy S7", SerialNumber = "SN00000002" }},
                {new Product { Id = 3, ModelCode = "SM-S8ABCD18", ProductName = "Galaxy S8", SerialNumber = "SN00000003" }},
                {new Product { Id = 4, ModelCode = "SM-S8ABCD19", ProductName = "Galaxy S9", SerialNumber = "SN00000004" }},
                {new Product { Id = 5, ModelCode = "SM-S8ABCD10", ProductName = "Galaxy S10", SerialNumber = "SN00000005" }}
            };
        }
    }
}
