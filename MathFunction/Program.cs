using System.Diagnostics;
using MathFunction;

class Program
{

    static void Main()
    {
        ProcessFormula.RunProcess();
        RunFunction();
        Restart();



    }

    static void Restart()
    {
        Console.WriteLine("Would you like to restart Counting? (y/n)");
        var runAgain = Console.ReadLine();
        if (runAgain == "y")
        {
            Console.Clear();
            ProcessFormula.RunProcess();
            RunFunction();
        }
        else if (runAgain == "n")
        {
            Console.Clear();
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
        }
    }

    static void RunFunction()
    {
        var func = ProcessFormula.MathFunction;
        string? input1;
        string? input2;
        float number1;
        bool parse1;
        bool parse2;

        Console.WriteLine("Input your number : \n");
        if (ProcessFormula.inputMenu == "3")
        {
            Console.Write(" Input radiant (r) : ");
            input1 = Console.ReadLine();
            parse1 = float.TryParse(input1, out number1);
            Console.Clear();
            ProcessFormula.RunInvoker(number1);
        }
        else
        {
            Console.Write("Number 1 : ");
            input1 = Console.ReadLine();
            Console.Write("Number 2 : ");
            input2 = Console.ReadLine();

            parse1 = float.TryParse(input1, out number1);
            parse2 = float.TryParse(input2, out float number2);
            Console.Clear();
            ProcessFormula.RunInvoker(number1, number2);
        }


        Restart();
    }


}