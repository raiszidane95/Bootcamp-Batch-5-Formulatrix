using Animal;
public static class Program
{
    public static void Main()
    {
        Cat chibi = new Cat("chibi"); // instance of Cat 
        Dog blacky = new Dog("Blacky"); // instance of Dog
        chibi.Eat();
        blacky.Eat();
        Console.WriteLine("Hello World");
    }
}