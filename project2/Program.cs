
// Day 2 - Constructor 

using Cars;

public class Program
{
    public static void Main()
    {
        Engine engine = new Engine(90, 4, 1990);
        Car brio = new Car(engine, "brio", "gasoline", 50, "honda"); // this is refference of Car Constructor

        Console.WriteLine(brio.name);
        Console.WriteLine(brio.engine.cylinder);
        Console.WriteLine(brio.brand);
        Console.WriteLine(brio.fuelType);
    }
}