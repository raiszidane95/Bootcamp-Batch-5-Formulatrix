public class Program
{
    public static void Main()
    {
        FooBar fooBar = new FooBar();
        fooBar.PrintFooBar(12);
    }
}

public class FooBar
{
    public int userInput;
    public void PrintFooBar(int userInput)
    {
        for (int i = 0; i <= userInput; i++)
        {
            if (i < 1)
            {
                Console.WriteLine(i);
            }
            else if (i % 15 == 0)
            {
                Console.WriteLine("foobar");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"foo");

            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}