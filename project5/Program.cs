// Project-5 "Overriding"

using Animals;

public class Program
{
    public static void Main()
    {
        Animal animal = new();
        animal.MakeSound();

        Cat cat = new();
        cat.MakeSound();

        Ant ant = new();
        ant.MakeSound();
    }
}