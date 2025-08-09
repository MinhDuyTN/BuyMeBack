using BMB_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BMB_Services.DTOs;


namespace BuyMeBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            var success = await _userService.RegisterAsync(userRegisterDto.Username,
                                                            userRegisterDto.Email,
                                                            userRegisterDto.Password);
            if (!success) return BadRequest("Email already exists.");
            return Ok("Account created successfully.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto dto)
        {
            var token = await _userService.LoginAsync(dto.Email, dto.Password);
            if (token == null) return Unauthorized("Invalid credentials.");
            return Ok(new { token });
        }
    }
}
