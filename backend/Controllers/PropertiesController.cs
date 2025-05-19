using Microsoft.AspNetCore.Mvc;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase
    {
        private static List<Property> properties = new List<Property>
        {
            new Property
            {
                Id = 1,
                Name = "Ritz Hotel",
                Location = "Muharraq",
                PricePerNight = 120.87m,
                Description = "5-star hotel with a sea view"
            },
            new Property
            {
                Id = 2,
                Name = "City Center",
                Location = "Manama",
                PricePerNight = 1292.21m,
                Description = "Fully furnished apartment suitable for families"
            },
            new Property
            {
                Id = 3,
                Name = "Sea View",
                Location = "Saar",
                PricePerNight = 120.87m,
                Description = "5-star hotel with a sea view"
            }
        };

        [HttpGet]
        public IEnumerable<Property> GetAllProperties()
        {
            return properties;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var property = properties.FirstOrDefault(p => p.Id == id);
            if (property == null)
                return NotFound();

            properties.Remove(property);
            return NoContent();
        }
        [HttpPost]
public IActionResult AddProperty(Property newProperty)
{
    newProperty.Id = properties.Max(p => p.Id) + 1;
    properties.Add(newProperty);
    return CreatedAtAction(nameof(GetAllProperties), new { id = newProperty.Id }, newProperty);
}
    }
}