class Program
{
    public delegate void DelegateMethod();
    static void Main()
    {
        Crusher crusher = new Crusher();
        Printer printer = new Printer();

        DelegateMethod method = printer.PrintMethod;
        method += crusher.CrusherMethod;

        Invoker(method);
    }



    static void Invoker(DelegateMethod x)
    {
        x.Invoke();
    }
}

public class Crusher
{
    public void CrusherMethod()
    {
        Console.WriteLine("Crusher");
    }
}

public class Printer
{
    public void PrintMethod()
    {
        Console.WriteLine("Printer");
    }
}