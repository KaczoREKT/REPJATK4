namespace Solution4;

public class AnimalService
{
    public List<Animal> GetAll()
    {
        return DataStore.Animals;
    }

    public Animal GetById(int id)
    {
        return DataStore.Animals.FirstOrDefault(a => a.Id == id);
    }

    public void Create(Animal animal)
    {
        animal.Id = DataStore.Animals.Count + 1; // przydziel nowe ID
        DataStore.Animals.Add(animal);
    }

    public void Update(int id, Animal animalIn)
    {
        var index = DataStore.Animals.FindIndex(a => a.Id == id);
        if (index != -1)
        {
            DataStore.Animals[index] = animalIn;
        }
    }

    public void Delete(Animal animal)
    {
        DataStore.Animals.Remove(animal);
    }
}

public class VisitService
{
    public List<Visit> GetByAnimalId(int animalId)
    {
        return DataStore.Visits.Where(v => v.AnimalId == animalId).ToList();
    }

    public void Create(Visit visit)
    {
        visit.Id = DataStore.Visits.Count + 1; // przydziel nowe ID
        DataStore.Visits.Add(visit);
    }
}
