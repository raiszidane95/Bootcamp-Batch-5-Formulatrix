using LandAnimal;


public class Program
{
    public static void Main()
    {
        Cat chibi = new Cat();
        chibi.name = "chibi";
        Console.WriteLine(chibi.name);
        chibi.Meow();

        Dog blacky = new Dog();
        blacky.name = "blacky";
        blacky.race = "Bulldog";
        blacky.Guk();
        Console.WriteLine($"Blacky is s {blacky.race}");

    }
}