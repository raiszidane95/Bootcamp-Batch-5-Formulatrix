namespace Animal;
public class Dog : Animal // Inherit class of Animal 
{
    public Dog(String name) : base("Name of Animal")
    {
        Console.WriteLine(name);
    }
}