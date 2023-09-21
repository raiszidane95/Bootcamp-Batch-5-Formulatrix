namespace Animals;

public class Cat : Animal
{
    public string race = "Anggora";
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public new void Eat() // nethod Hiding of Animal Eat() -> Marked with Keyword "new"
    {
        Console.WriteLine("Cat Eating..");
    }

}
