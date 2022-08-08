using Microsoft.AspNetCore.Mvc;
using ProductsManagementBLL.Services.IServices;
using ProductsManagementDTOs.UsersDtos;

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

        /// <summary>
        /// This endpoint is used to retrive the jwt token after the user logs in
        /// </summary>
        /// <param name="dto"></param>
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var output = await _authService.Login(dto);
            return Ok(output);
        }
    }
}
