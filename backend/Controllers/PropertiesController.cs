using Microsoft.AspNetCore.Mvc;
using backend.Models;
namespace backend.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController : ControllerBase {
        [HttpGet]
        public IEnumerable<Property> GetAllProperties()
        {   
            var properties = new List<Property>
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
                }
            };
            return properties;
        }
    }
}

