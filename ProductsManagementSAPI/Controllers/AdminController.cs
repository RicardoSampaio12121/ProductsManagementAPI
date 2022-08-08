using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductsManagementBLL.Services.IServices;
using ProductsManagementBLL.Utils;
using ProductsManagementDTOs.UsersDtos;

namespace ProductsManagementSAPI.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin")]
    [Route("admin")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        /// <summary>
        /// This endpoint returns the information of an user
        /// </summary>
        /// <param name="userId"></param>
        [HttpGet("getUser/{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {
            var user = await _adminService.GetUser(userId);
            return Ok(user);
        }

        /// <summary>
        /// This endpoint is used to create a new user in the database
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("newUser")]
        public async Task<IActionResult> CreateNewUser(NewUserDto dto)
        {
            var newUser = await _adminService.CreateNewUser(dto);

            return CreatedAtAction(nameof(GetUser), new { userId = newUser.Id }, newUser);

        }
    }
}
