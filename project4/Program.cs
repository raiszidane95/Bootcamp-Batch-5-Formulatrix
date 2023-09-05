using Animal;
public static class Program
{
    public static void Main()
    {
        Cat chibi = new Cat("chibi");
        Dog blacky = new Dog("Blacky");
        chibi.Eat();
        blacky.Eat();
        Console.WriteLine("Hello World");
    }
}