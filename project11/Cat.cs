namespace Animals;

public class Cat : Animal
{
    bool isJump = true;

    public new void MakeSound()
    {
        Console.WriteLine("Meow");
    }
    public void Jump()
    {
        Console.WriteLine("Jump status = " + isJump);
    }
    public new void Eat() //recommended : new, kalau ga ya gapapa
    {
        Console.WriteLine("Cat Eat");
    }
}
