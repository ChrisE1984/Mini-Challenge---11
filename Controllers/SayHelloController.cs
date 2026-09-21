
using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge___10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route ("username/{username}")]
        public string UserName(string username)
        {
            return $"Hello {username}";
        }
    }
}