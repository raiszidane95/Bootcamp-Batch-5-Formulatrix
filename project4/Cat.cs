namespace Animal;

public class Cat : Animal // Inherit class of Animal 
{
    public Cat(string name) : base("Name of Animal") // Constructor can doing a method
    {
        Console.WriteLine(name);
    }


}
