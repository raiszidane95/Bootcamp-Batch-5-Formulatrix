namespace MathFunction;

public class ProcessFormula
{
    public static Func<float, float, float>? MathFunction;

    public static Func<float, float>? MathFunction2;
    public static Func<float, float, float>? listFunc;
    public static string? inputMenu;


    public void ProcessFunction(float x, float y)
    {
        Console.WriteLine(MathFunction?.Invoke(x, y));
    }

    public static void RunProcess()
    {
        Console.WriteLine("\nSelect Count Function (1,2) : ");
        Console.WriteLine("1. Count Squere Area");
        Console.WriteLine("2. Count Triangle Area");
        Console.WriteLine("3. Count Circle Area");
        Console.WriteLine("\n0. Count with all formula ( which has 2 input numbers)");
        string? input = Console.ReadLine();
        Console.Clear();

        if (input == "1")

        {
            MathFunction = MathFormula.SquareArea;
            inputMenu = input;
        }
        else if (input == "2")
        {
            MathFunction = MathFormula.TriangleArea;
            inputMenu = input;
        }
        else if (input == "3")
        {
            MathFunction2 = MathFormula.CircleArea;
            inputMenu = input;
        }
        else if (input == "0")
        {
            MathFunction = MathFormula.SquareArea;
            listFunc = MathFunction += MathFormula.TriangleArea;
            inputMenu = input;

        }
        else
        {
            Console.WriteLine("invalid choosen count function");
            Environment.Exit(0);
        }

    }

    public static void RunInvoker(float number1)
    {
        if (inputMenu == "3")
        {
            Console.WriteLine($"Result = {MathFunction2?.Invoke(number1)}");
        }
    }
    public static void RunInvoker(float number1, float number2)
    {
        if (inputMenu == "1" | inputMenu == "2")
        {
            Console.WriteLine($"Result = {MathFunction!.Invoke(number1, number2)}\n");
        }
        else if (inputMenu == "0")
        {
            Delegate[] delegates = listFunc!.GetInvocationList();
            foreach (Func<float, float, float> d in delegates)
            {
                Console.WriteLine($"The result = {d.Invoke(number1, number2)}");
            }
        }
    }


}
