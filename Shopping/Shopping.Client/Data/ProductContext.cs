using Microsoft.Extensions.Diagnostics.HealthChecks;
using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {

        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "Test",
                Description = "Test",
                ImageFile="image1",
                Price = 0.25M,
                Category = "Test",

            },
            new Product()
            {
                Name = "Test",
                Description = "Test",
                ImageFile="image1",
                Price = 0.25M,
                Category = "Test",

            },
            new Product()
            {
                Name = "Test",
                Description = "Test",
                ImageFile="image1",
                Price = 0.25M,
                Category = "Test",

            }
        };
    }
}
