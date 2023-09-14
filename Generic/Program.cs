// Generic, Constraint, Generic Collection

using Generic;

public static class MyExtensionMethod  // this is Extension Method to that create Dump method to print variable
{
    public static void Print(this object x)
    {
        Console.WriteLine(x);
    }
}

public class Program
{
    public static void Main()
    {

        List<ICar> listCar = new List<ICar>(); // this is list Generic 
        listCar.Add(new Car());                 // Adding class who implement contract of
        listCar.Add(new Honda());               // ICar to the list of ICar
        listCar.Add(new Toyota());

        Dictionary<int, string> dict = new();
        dict.Add(3, "3");
        dict.Add(4, "5");

        Console.WriteLine(dict[3]);
        // Console.WriteLine(dict[1]); // exception, because no dictionary with index[1]
        Console.WriteLine(dict[4]);

        listCar[0].CarEngineRun();
        listCar[1].CarEngineRun();
        listCar[2].CarEngineRun();

        Checker("Terserah", 12);
        Checker(15);
        // Checker("String"); // Tidak bisa karena parameternya bukan struct 
        // Checker(new Car()); // parameternya bukan struct 
        // Checker(new Tire()); // param bukan struct
    }

    static void Checker<T>(T a) where T : struct
    {
        Console.WriteLine(a);
    }
    static void Checker<T, T2>(T a, T2 b) where T : class where T2 : struct
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}



