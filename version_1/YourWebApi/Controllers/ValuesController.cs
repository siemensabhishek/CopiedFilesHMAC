using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using softaware.Authentication.Hmac;

namespace YourWebApi.Controllers
{
    [Authorize(AuthenticationSchemes = HmacAuthenticationDefaults.AuthenticationScheme)]
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet("hello")]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }
    }

}
