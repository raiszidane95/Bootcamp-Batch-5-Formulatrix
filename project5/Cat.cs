namespace Animals;

public class Cat : Animal
{
    public Cat()
    {
    }


    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
    public int MakeSound(int a)
    {
        return a;
    }

}