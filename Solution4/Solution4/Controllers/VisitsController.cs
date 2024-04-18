using Microsoft.AspNetCore.Mvc;
using Solution4.Models;

namespace Solution4.Controllers;

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