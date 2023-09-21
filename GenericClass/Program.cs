using GenericClass;

class Program
{
    public static void Main()
    {
        Car<Tire, int> car = new Car<Tire, int>(new Tire(), 3);
        car.Check();
        Console.WriteLine($"{car.name}");
        car.year.Dump();
        Car<TireBrand, int> car2 = new Car<TireBrand, int>(new TireBrand(), 2);
        car2.CheckYear();
    }
}

public static class ExtensionMethod
{
    public static void Dump(this object x)
    {
        Console.WriteLine(x);
    }
}