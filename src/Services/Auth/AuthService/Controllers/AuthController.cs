using Application.UseCases;
using Interface_Adapters.Auth;
using Interface_Adapters.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly RegisterUseCase<RegisterUserDto, AuthResult> _registerUseCase;
        public AuthController(RegisterUseCase<RegisterUserDto, AuthResult> registerUseCase)
        {
            _registerUseCase = registerUseCase;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto registerRequest)
        {
            var authResult = await _registerUseCase.Execute(registerRequest);
            return Ok("Register endpoint");
        }
    }
}
