namespace Animal;

public class Animal
{
    public string? name;
    public string? age;

    public Animal(string name)
    {
        this.name = name;
    }
    public Animal() { }
    public void Eat()
    {
        Console.WriteLine("Eat");
    }
}
