using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JoVision_Backend_tasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreeterController : ControllerBase
    {
      
         [HttpGet]
         public IActionResult GetGreeting([FromQuery] string name = "anonymous")
         {
            if (name == "Aya" || name == "aya")
                name = "Aya";
            else name = "Anonymous";
                return Ok($"Hello {name}");
         }
    
       
    }
}
