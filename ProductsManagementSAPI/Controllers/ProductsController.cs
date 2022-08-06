using Microsoft.AspNetCore.Mvc;
using ProductsManagementBLL.Services.IServices;
using ProductsManagementDTOs;
using ProductsManagementEntities;

namespace ProductsManagementSAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : Controller
    {

        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("getProduct/{productId}")]
        public async Task<ActionResult<Products>> GetProduct(int productId)
        {
            var product = await _productsService.GetProduct(productId);
            return Ok(product);
        }

        [HttpGet("listAllProducts")]
        public async Task<ActionResult<List<Products>>> ListAllProducts()
        {
            var products = await _productsService.GetAllProducts();
            return Ok(products);
        }

        [HttpPost("addProduct")]
        public async Task<IActionResult> AddNewProduct(AddProductDto dto)
        {
            var createdProduct = await _productsService.AddNewProduct(dto);
            return CreatedAtAction(nameof(GetProduct), new { productId = createdProduct.Id }, createdProduct);
        }

        [HttpPut("updateStock")]
        public async Task<IActionResult> UpdateStock(UpdateStockDto dto)
        {
            await _productsService.UpdateStock(dto);
            return NoContent();
        }

        [HttpDelete("deleteProduct/{productId}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            await _productsService.DeleteProduct(productId);
            return NoContent();
        }
    }
}