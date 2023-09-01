using Api.Repositories.ProductRep;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRep _productRep;

        public ProductsController(IProductRep productRep)
        {
            _productRep = productRep;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRep.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRep.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
    }
}