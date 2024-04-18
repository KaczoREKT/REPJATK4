public static class DataStore
{
    public static List<Animal> Animals { get; } = new List<Animal>
    {
        new Animal { Id = 1, Name = "Burek", Category = "Pies", Breed = "Mieszaniec", Color = "Brązowy" },
        new Animal { Id = 2, Name = "Filemon", Category = "Kot", Breed = "Syjamski", Color = "Biały" }
    };

    public static List<Visit> Visits { get; } = new List<Visit>();
}