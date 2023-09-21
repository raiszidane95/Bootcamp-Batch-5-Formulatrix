// Extension Method -> making own method like Dump() to dumping or print some data

static class MyExtensionMethod  // this is Extension Method to that create Dump method to print variable
{
    public static void Dump(this string x)
    {
        Console.WriteLine(x);
    }
    public static void Dump(this double x)
    {
        Console.WriteLine(x);
    }
    public static void Dump(this decimal x)
    {
        Console.WriteLine(x);
    }
    public static void Dump(this int x)
    {
        Console.WriteLine(x);
    }
    public static void Dump(this bool x)
    {
        Console.WriteLine(x);
    }


}
public class Program
{

    //Why dont use DOUBLE
    static void Main()
    {
        int a = 1; //a + b = 3
        int b = 2;
        bool resultab = 3 == (a + b); //true
        resultab.Dump();

        float c = 0.1f; //c+d = 0.3f 
        float d = 0.2f;
        bool resultcd = 0.3f == (c + d); // false true
        resultcd.Dump();

        double e = 0.1; //e+f = 0.300000000004 
        double f = 0.2;
        bool resultef = 0.3 == (e + f); // false
        resultef.Dump();


        //Double
        double doubleA = 0.1;
        doubleA.Dump();
        double doubleB = 0.2;
        doubleB.Dump();
        double doubleC = a + b;
        doubleC.Dump();
        (c == 0.3).Dump();

        // Instead using double its recomend using Decimal for precition value 

        //Decimal
        decimal decimalNumber = 1000000.1M;
        decimalNumber.Dump();
        decimal decimalNumber2 = 2000000.2M;
        decimalNumber2.Dump();
        (decimalNumber + decimalNumber2 == 3000000.3M).Dump();
    }



}