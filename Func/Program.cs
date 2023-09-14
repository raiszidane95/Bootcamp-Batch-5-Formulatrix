class Program
{
    static void Main()
    {
        Func<int> myFunction = RetrunNumberOne; // Func with return output
        Func<int, int, int> fucnWithPassingData = Sum; // Finc With return and passing variable data

        Func<int, int, int> multicastFunc = Sum;
        multicastFunc += Substract;  // MulticastFunc
        Func<int, int, int> listFunction = multicastFunc += Multiply;

        Delegate[] delegates = listFunction.GetInvocationList();    // Get List of Function that has Added in multicastFunc
        foreach (Func<int, int, int> d in delegates)                // it will return 
        {                                                           //  "The result is = 15" -> its The Sum Func (a+b)
            Console.WriteLine($"The result = {d.Invoke(10, 5)}");   //  "The result is = 15" -> its The Substract Func (a-b)
        }

        Console.WriteLine($"\n{multicastFunc.Invoke(15, 9)} \n"); // it will return the last of added function in multicastFunc (Multiply)

        Console.WriteLine(fucnWithPassingData.Invoke(3, 5));
        Console.WriteLine(myFunction.Invoke());
    }

    static int RetrunNumberOne()
    {
        return 1;
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static int Substract(int a, int b)
    {
        return a - b;
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }

}