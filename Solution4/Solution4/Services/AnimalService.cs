namespace Solution4;

public class AnimalService
{
    public List<Animal> GetAll()
    {
        return Collection.Animals;
    }

    public Animal GetById(int id)
    {
        return Collection.Animals.FirstOrDefault(a => a.Id == id);
    }

    public void Create(Animal animal)
    {
        animal.Id = Collection.Animals.Count + 1; // przydziel nowe ID
        Collection.Animals.Add(animal);
    }

    public void Update(int id, Animal animalIn)
    {
        var index = Collection.Animals.FindIndex(a => a.Id == id);
        if (index != -1)
        {
            Collection.Animals[index] = animalIn;
        }
    }

    public void Delete(Animal animal)
    {
        Collection.Animals.Remove(animal);
    }
}


