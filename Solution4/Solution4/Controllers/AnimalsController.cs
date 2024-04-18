using Microsoft.AspNetCore.Mvc;

namespace Solution4.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly AnimalService animalService;

    public AnimalsController(AnimalService animalService)
    {
        this.animalService = animalService;
    }

    [HttpGet]
    public ActionResult<List<Animal>> GetAll()
    {
        return animalService.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Animal> GetById(int id)
    {
        var animal = animalService.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }
        return animal;
    }

    [HttpPost]
    public ActionResult<Animal> Create(Animal animal)
    {
        animalService.Create(animal);
        return CreatedAtAction(nameof(GetById), new { id = animal.Id }, animal);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Animal animalIn)
    {
        var animal = animalService.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }
        animalService.Update(id, animalIn);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var animal = animalService.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }
        animalService.Delete(animal);
        return NoContent();
    }
}


