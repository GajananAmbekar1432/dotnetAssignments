using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        [HttpPost("add-property")]
        public IActionResult AddProperty([FromQuery] Model.Property property)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!property.name.Contains("Realty"))
            {
                throw new InvalidPropertyException("Property name must contain 'Realty'");
            }

            return Ok(new { Message = "Property added successfully!" ,Property=property});
        }
    }
}
