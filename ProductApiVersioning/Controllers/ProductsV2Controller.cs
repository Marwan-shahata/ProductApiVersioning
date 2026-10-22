
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using ProductApiVersioning.Data;
using ProductApiVersioning.DTOs.V2;

namespace ProductApiVersioning.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsV2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductV2Dto>> GetProducts()
        {
            var products = ProductData.Products
                .Select(p => new ProductV2Dto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = p.CategoryName
                })
                .ToList();

            return Ok(products);
        }
    }
}
