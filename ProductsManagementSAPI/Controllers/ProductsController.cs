using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductsManagementBLL.Services.IServices;
using ProductsManagementDTOs;
using ProductsManagementEntities;

namespace ProductsManagementSAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("products")]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        /// <summary>
        /// Api endpoint to retrieve the information of a product given it's Id
        /// </summary>
        /// <param name="productId"></param>
        [HttpGet("getProduct/{productId}")]
        public async Task<ActionResult<Products>> GetProduct(int productId)
        {
            var product = await _productsService.GetProduct(productId);
            return Ok(product);
        }

        /// <summary>
        ///  Api endpoint to retrieve the information of all products
        /// </summary>
        [HttpGet("listAllProducts")]
        public async Task<ActionResult<List<Products>>> ListAllProducts()
        {
            var products = await _productsService.GetAllProducts();
            return Ok(products);
        }

        /// <summary>
        /// Api endpoint to add a new product to the database
        /// </summary>
        /// <param name="dto"></param>
        [HttpPost("addProduct")]
        public async Task<IActionResult> AddNewProduct(AddProductDto dto)
        {
            var createdProduct = await _productsService.AddNewProduct(dto);
            return CreatedAtAction(nameof(GetProduct), new { productId = createdProduct.Id }, createdProduct);
        }

        /// <summary>
        /// Api endpoint to update the stock of an existing product in the database
        /// </summary>
        /// <param name="dto"></param>
        [HttpPut("updateStock")]
        public async Task<IActionResult> UpdateStock(UpdateStockDto dto)
        {
            await _productsService.UpdateStock(dto);
            return NoContent();
        }

        /// <summary>
        /// Api endpoint to delete a product from the database
        /// </summary>
        /// <param name="productId"></param>
        [HttpDelete("deleteProduct/{productId}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            await _productsService.DeleteProduct(productId);
            return NoContent();
        }
    }
}