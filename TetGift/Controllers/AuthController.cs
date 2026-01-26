using Microsoft.AspNetCore.Mvc;
using TetGift.BLL.Dtos;
using TetGift.BLL.Interfaces;

namespace TetGift.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("register/request-otp")]
        public async Task<IActionResult> RequestOtp([FromBody] RegisterRequest req)
        {
            await _auth.RequestRegisterOtpAsync(req);
            return Ok(new { message = "OTP sent." });
        }

        [HttpPost("register/verify-otp")]
        public async Task<IActionResult> VerifyOtp([FromBody] VerifyOtpRequest req)
        {
            var result = await _auth.VerifyRegisterOtpAsync(req);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest req)
        {
            var result = await _auth.LoginAsync(req);
            return Ok(result);
        }
    }
}
