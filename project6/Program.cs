// Project-5 "Method Hiding"

using Animals;

public class Program
{
    public static void Main()
    {
        Cat cat = new();
        Animal animal = cat;

        Console.WriteLine(animal.name);
        animal.MakeSound(); // Already Fill with instance of cat

        Console.WriteLine("-----");

        Console.WriteLine(cat.name);
        cat.MakeSound();
        cat.Eat();

    }
}