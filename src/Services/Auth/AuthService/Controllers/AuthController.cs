using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            
        }
    }
}
