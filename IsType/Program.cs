public class Program
{
    object x = 32;
    public static void Main()
    {

    }
}

public static class MyExtensionMethod
{
    public static void CheckType(this object x)
    {
        if (x is int)
        {
            Console.WriteLine($"this is Int Type");
        }
        if (x is ValueType)
        {
            Console.WriteLine("This is ValueType");
        }
    }
}