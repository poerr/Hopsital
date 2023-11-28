using Hospital.API.Services;
using Hospital.API.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(
            IAuthService authService
            )
        {
            _authService = authService;
        }
        [HttpPost("RegisterPatient")]
        public async Task<IActionResult> RegisterPatient([FromBody] RegisterPatientDto dto)
        {
            bool successful = await _authService.RegisterPatient(dto);
            if (successful)
            {
                return Ok("Registered successfully! Login to continue.");
            }
            else
            {
                return BadRequest("There was an error with registering your account!");
            }
        }
    }
}
