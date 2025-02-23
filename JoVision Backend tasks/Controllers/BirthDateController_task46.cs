using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JoVision_Backend_tasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirthDateController_task46 : ControllerBase
    {
        [HttpPost]
        public IActionResult GetAge([FromForm] string name = "anonymous", [FromForm] string birthdate = null)
        {
            if (string.IsNullOrEmpty(birthdate) || !DateTime.TryParse(birthdate, out DateTime birthDateValue)) /// *Note*  date like this : 2002-10-15 
            {
                return Ok($"Hello {name}, I can’t calculate your age without knowing your birthdate!");
            }

            if (birthDateValue.Year < 1 || birthDateValue.Year >= 2025)
            {
                return BadRequest("Invalid birthdate! Year must be between 1 and 2025.");
            }

            int age = DateTime.UtcNow.Year - birthDateValue.Year;
            if (DateTime.UtcNow < birthDateValue.AddYears(age))
            {
                age--;
            }

            return Ok($"Hello {name}, your age is {age}");
        }
    }
}
