namespace Animals;

public class Cat : Animal
{
    public string race = "Anggora";
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public new void Eat()
    {
        Console.WriteLine("Cat Eating..");
    }

}
