using GenericClass;

class Program
{
    public static void Main()
    {

        Car<Tire, int> car = new Car<Tire, int>(new Tire(), 3);
        car.Check();
        Console.WriteLine($"{car.name}");

    }
}
