using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController( IProductService productService)
        {
            _productService= productService;

        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Products>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();

            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponse<Products>>> GetProduct(int Id)
        {
            var result = await _productService.GetProductAsync(Id);

            return Ok(result);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Products>>>> GetProductsByCategory(String categoryUrl)
        {
            var result = await _productService.GetProductsByCategory(categoryUrl);

            return Ok(result);
        }


    }
}
