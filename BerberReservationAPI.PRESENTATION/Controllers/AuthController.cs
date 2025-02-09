using AutoMapper;
using BerberReservationAPI.APPLICATION.Managers;
using BerberReservationAPI.DOMAIN.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BerberReservationAPI.PRESENTATION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IOtpService _otpService;

        public AuthController(IOtpService otpService,IAuthService authService)
        {
            _otpService = otpService;
            _authService = authService;
        }
        [HttpPost("sendotp")]
        public async Task<IActionResult> SendOtp([FromBody] string phoneNumber)
        {
            var otp = _otpService.GenerateOtpAsync(phoneNumber);
            return Ok("OTP gönderildi.");
        }

        [HttpPost("verifyotp")]
        public async Task<IActionResult> VerifyOtp([FromBody] OtpRequestDto request)
        {
            string result = await _authService.LoginWithOtpAsync(request.PhoneNumber, request.Code);
            return Ok(result);
        }
    }
    public class OtpRequestDto
    {
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
    }
}
