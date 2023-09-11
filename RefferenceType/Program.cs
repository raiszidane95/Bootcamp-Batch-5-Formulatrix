public class Program
{

    public static void Main()
    {

        Console.WriteLine($"\nRefference Type");
        Car car = new Car();
        Add(car);
        Console.WriteLine(car.name);

        Console.WriteLine($"\nref Keyword");
        int numberRef = 2; // must be assign in this Method
        RefKeyword(ref numberRef);
        Console.WriteLine(numberRef);

        Console.WriteLine($"\nOut Keyword");
        // variable numberOut is readonly
        int numberOut = 2; // unnecessary assignment in this Method => value will be 10 
        OutKeyword(out numberOut);
        Console.WriteLine(numberOut);

        Console.WriteLine($"\nIn Keyword");
        int numberIn = 2; // Must assign the value in this Method, cannot unassign => value will be 2
        InKeyword(in numberIn);
        Console.WriteLine(numberIn);

    }

    static void Add(Car car1)
    {
        car1.name = "Mercedes";
        Console.WriteLine($"{car1.name}");

    }
    static void RefKeyword(ref int x)
    {
        x = 1; // unnecessary asignned on this method
        Console.WriteLine(x);

    }

    static void OutKeyword(out int x)
    {
        x = 10; // must be assign in this control before leave
        Console.WriteLine(x);

    }
    static void InKeyword(in int numberIn = 1)
    {
        int add = numberIn + 10; //bisa karena masuk variable baru, not change 'x'
        Console.WriteLine(add); // output 12

        // numberIn = 1; //in is readonly
        Console.WriteLine(numberIn);// output : 2
    }
}


public class Car
{
    public string name = "Honda";

}

