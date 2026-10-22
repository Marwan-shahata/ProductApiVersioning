
using ProductApiVersioning.Models;

namespace ProductApiVersioning.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 25000,
                CategoryName = "Electronics"
            },
            new Product
            {
                Id = 2,
                Name = "Mouse",
                Price = 500,
                CategoryName = "Accessories"
            }
        };
    }
}
