using Solution4.Models;

namespace Solution4;

public class VisitService
{
    public List<Visit> GetByAnimalId(int animalId)
    {
        return Collection.Visits.Where(v => v.AnimalId == animalId).ToList();
    }

    public void Create(Visit visit)
    {
        visit.Id = Collection.Visits.Count + 1;
        Collection.Visits.Add(visit);
    }
}