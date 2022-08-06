using Microsoft.AspNetCore.Mvc;
using ProductsManagementDTOs;

namespace ProductsManagementAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : Controller
    {
        [HttpPost("addProduct")]
        public async Task<IActionResult> AddNewProduct(AddProductDto dto)
        {

        }
    }
}
