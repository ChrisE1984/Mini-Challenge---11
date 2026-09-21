using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge___10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadlibsController : ControllerBase
    {
        [HttpGet("game/{adjective1}/{noun1}/{pluralnoun}/{verb}/{color}/{adjective2}/{number}/{exclamation}/{noun2}/{sillyword}")]
        public ActionResult Game(string adjective1, string noun1, string pluralnoun, string verb, string color, string adjective2, string number, string exclamation, string noun2, string sillyword)
        
        {
            return Ok($"Today our class took a field trip to the {adjective1} Museum of Ancient {noun1}. We rode on a very loud bus with sticky {pluralnoun}. While our teacher was {verb}, my best friend dropped a {color} sandwich on the floor. It was so {adjective2}. The tour guide showed us {number} ancient artifacts. Suddenly, someone yelled {exclamation}! A wild {noun2} jumped out from behind a display case and shouted {sillyword}! We all laughed and ran back to the bus.");
        }
    

        

    }
}
