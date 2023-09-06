namespace Animals;

public class Animal
{
    public string name = "Hewan";
    public int age = 2;

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Sounding...");
    }
    public void Eat()
    {
        Console.WriteLine("Animal Eating...");
    }
}
