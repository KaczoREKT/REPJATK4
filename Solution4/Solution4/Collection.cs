using Solution4.Models;

public static class Collection
{
    public static List<Animal> Animals { get; } = new List<Animal>
    {
        new Animal { Id = 1, Name = "MACZASKAN", Category = "GUBAŁÓWKA", Breed = "JASNY", Color = "CIEMNY" },
        new Animal { Id = 2, Name = "KACZYSTAN", Category = "KOD", Breed = "SCHIZOWY", Color = "KOLOROWY" }
    };

    public static List<Visit> Visits { get; } = new List<Visit>();
}