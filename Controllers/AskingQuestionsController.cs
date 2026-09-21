using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge___10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AskingQuestions : ControllerBase
    {
       [HttpGet]
       [Route("ask/{name}/{time}")]
    
       public string Ask(string name, string time){
      
        bool success = int.TryParse(time, out int realtime);

        if (success)

        {
            return $"Your name is {name} and you woke up at {realtime}";
        }
        else
        {
            return "That was not a valid entry.";
        }
    }
}
}