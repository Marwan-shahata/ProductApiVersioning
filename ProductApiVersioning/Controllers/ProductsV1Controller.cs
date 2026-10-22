
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using ProductApiVersioning.Data;
using ProductApiVersioning.DTOs.V1;

namespace ProductApiVersioning.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsV1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductV1Dto>> GetProducts()
        {
            var products = ProductData.Products
                .Select(p => new ProductV1Dto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                })
                .ToList();

            return Ok(products);
        }
    }
}
