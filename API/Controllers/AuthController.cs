using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using restApi.DTOs;

namespace restApi.Controllers
{
    [ApiController]
    [Route("api/Auth")]

    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        public AuthController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerDto.Username,
                Email = registerDto.Username
            };

            if (string.IsNullOrWhiteSpace(registerDto.Password))
            {
                return BadRequest("Password is required");
            }

            var identityResult = await _userManager.CreateAsync(identityUser, registerDto.Password);

            if (!identityResult.Succeeded)
            {
                // Return all errors from Identity user creation
                return BadRequest(identityResult.Errors);
            }

            if (registerDto.Roles != null && registerDto.Roles.Any())
            {
                var roleResult = await _userManager.AddToRolesAsync(identityUser, registerDto.Roles);
                if (!roleResult.Succeeded)
                {
                    return BadRequest(roleResult.Errors);
                }
            }

            return Ok("Registration successful");
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] RegisterDto registerDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerDto.Username,
                Email = registerDto.Username
            };
            await _userManager.CreateAsync(identityUser);
            return Unauthorized("Login failed");
        }
    }
}