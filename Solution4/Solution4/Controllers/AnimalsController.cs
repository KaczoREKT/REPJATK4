using Microsoft.AspNetCore.Mvc;

namespace Solution4.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly AnimalService _animalService;

    public AnimalsController(AnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public ActionResult<List<Animal>> GetAll()
    {
        return _animalService.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Animal> GetById(int id)
    {
        var animal = _animalService.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }
        return animal;
    }

    [HttpPost]
    public ActionResult<Animal> Create(Animal animal)
    {
        _animalService.Create(animal);
        return CreatedAtAction(nameof(GetById), new { id = animal.Id }, animal);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Animal animalIn)
    {
        var animal = _animalService.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }
        _animalService.Update(id, animalIn);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var animal = _animalService.GetById(id);
        if (animal == null)
        {
            return NotFound();
        }
        _animalService.Delete(animal);
        return NoContent();
    }
}

[ApiController]
[Route("api/[controller]")]
public class VisitsController : ControllerBase
{
    private readonly VisitService _visitService;

    public VisitsController(VisitService visitService)
    {
        _visitService = visitService;
    }

    [HttpGet("{animalId}/visits")]
    public ActionResult<List<Visit>> GetByAnimalId(int animalId)
    {
        return _visitService.GetByAnimalId(animalId);
    }

    [HttpPost]
    public ActionResult<Visit> Create(Visit visit)
    {
        _visitService.Create(visit);
        return CreatedAtAction(nameof(GetByAnimalId), new { animalId = visit.AnimalId }, visit);
    }
}
