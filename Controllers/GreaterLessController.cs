using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge___10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterLessController : ControllerBase
    {
        [HttpGet("game/{firstnumber}/{secondnumber}")]
        public ActionResult Game(string firstnumber, string secondnumber)
        {
            bool success = int.TryParse(firstnumber, out int realfirstnumber);
            bool success2 = int.TryParse(secondnumber, out int realsecondnumber);

            if (success && success2)
            {
                if (realfirstnumber > realsecondnumber)
                {
                    return Ok($"Your first number is {realfirstnumber} and your second number is {realsecondnumber}. {realfirstnumber} is greater than {realsecondnumber}");
                }
                else if (realfirstnumber < realsecondnumber)
                {
                    return Ok($"Your first number is {realfirstnumber} and your second number is {realsecondnumber}. {realfirstnumber} is less than {realsecondnumber}");
                }
                else
                {
                    return Ok($"Your first number is {realfirstnumber} and your second number is {realsecondnumber}. {realfirstnumber} is equal to {realsecondnumber}");
                }
            }

            return NotFound("That was not a valid input. Please enter a number");
        }

    }
}