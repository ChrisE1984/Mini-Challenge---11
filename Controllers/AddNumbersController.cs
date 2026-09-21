using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge___10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddNumbers : ControllerBase
    {

        
        [HttpGet ("numbers/{firstnumber}/{secondnumber}")]
        
        public ActionResult Numbers(string firstnumber, string secondnumber)
      
        {
            
            
            bool success = int.TryParse(firstnumber, out int realfirstnumber);
            bool success2 = int.TryParse(secondnumber, out int realsecondnumber);

            if (success && success2)
            
            {
            int sum = realfirstnumber + realsecondnumber;
            return Ok($"The numbers you entered add up to {sum}.");
            }
            else
            {
            return NotFound("That was not a valid entry.");
            }
        }
    }
}