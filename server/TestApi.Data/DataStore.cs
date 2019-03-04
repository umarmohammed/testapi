using System.Collections.Generic;
using TestApi.Domain.Domain;

namespace TestApi.Data
{
    public static class DataStore
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                {new Product { ModelCode = "SM-S8ABCD13", ProductName = "Galaxy S3", SerialNumber = "SN00000001" }},
                {new Product { ModelCode = "SM-S8ABCD17", ProductName = "Galaxy S7", SerialNumber = "SN00000002" }},
                {new Product { ModelCode = "SM-S8ABCD18", ProductName = "Galaxy S8", SerialNumber = "SN00000003" }},
                {new Product { ModelCode = "SM-S8ABCD19", ProductName = "Galaxy S9", SerialNumber = "SN00000004" }},
                {new Product { ModelCode = "SM-S8ABCD10", ProductName = "Galaxy S10", SerialNumber = "SN00000005" }}
            };
        }
    }
}
