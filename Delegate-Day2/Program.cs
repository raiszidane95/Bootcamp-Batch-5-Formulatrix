using Delegate_Day2;
class Program
{
    public delegate int CalculatorMethod(int a, int b);
    public delegate void DelegateMethod();
    static void Main()
    {
        Printer printer = new Printer();
        Cleaner cleaner = new Cleaner();

        DelegateMethod method = printer.PrinterMethod;
        method += cleaner.Cleaning;
        method.Invoke();

        CalculatorMethod x = Calculator.Add;
        x += Calculator.Multiply;

    }

}

