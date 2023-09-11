using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        string number = "20i0";
        int result;

        bool isParseAble = int.TryParse(number, out result);
        Console.WriteLine(isParseAble);
        Console.WriteLine(result);

        int reusltInt = int.Parse(number);
        Console.WriteLine(reusltInt);
    }

}