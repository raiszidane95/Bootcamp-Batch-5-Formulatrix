using LandAnimal;

public class Program
{
    public static void Main()
    {
        Cat chibi = new Cat();  // Instance of object Animal
        chibi.name = "Chibi";
        Console.WriteLine($"This is {chibi.name}");
        chibi.Meow();

        Dog blacky = new Dog();  // Instance of object Animal
        blacky.name = "Blacky";
        Console.WriteLine($"And this is {blacky.name}");
        blacky.Guk();
    }
}
