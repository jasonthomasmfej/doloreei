using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest login)
    {
        // Validate login credentials (this is simplified for illustration)
        if (login.Username == "admin" && login.Password == "password")
        {
            // Authentication successful, you might create a JWT token or set a cookie/session
            // For simplicity, returning a JSON response indicating success
            return Ok(new { Message = "Login successful" });
        }
        else
        {
            // Authentication failed, return a 401 Unauthorized status code
            return Unauthorized(new { Message = "Invalid credentials" });
        }
    }
}
