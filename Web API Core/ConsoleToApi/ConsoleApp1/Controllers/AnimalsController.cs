using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name = "Zulu"},
                new AnimalModel() {Id = 2, Name = "Shawlin"}
            };
        }
        
        [Route("", Name = "All" )]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return LocalRedirect("~/api/animals");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(name);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var animal = animals.FirstOrDefault(x => x.Id == id);

            if (animal == null)
            {
                return NotFound("No animal with this ID");
            }
            return Ok(animal);
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);

            return CreatedAtAction("GetAnimalsById", new { id = animal.Id } , animal);
        }
    }
}
