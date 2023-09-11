public class Program
{

    public static void Main()
    {
        var x = new Car(); //var => Car // var is defined by Car class
                           //x = 3; // 3 is not Car

        Console.WriteLine($"{x.name}");

        var number = 1;
        double number2 = number;
        Console.WriteLine(number2);
        ;
    }
}

public class Car
{
    public string name = "Honda";
}

