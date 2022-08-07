using Microsoft.AspNetCore.Mvc;
using ProductsManagementBLL.Services.IServices;
using ProductsManagementDTOs.AuthenticationDtos;

namespace ProductsManagementSAPI.Controllers
{
    [ApiController]
    [Route("authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authService;

        public AuthenticationController(IAuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var output = await _authService.Login(dto);
            return Ok(output);
        }
    }
}
