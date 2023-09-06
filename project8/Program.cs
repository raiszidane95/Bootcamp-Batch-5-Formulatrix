/*
    Interface Seggregation Principle
*/

using Game;

public class Program
{
    public static void Main()
    {
        MobileLegendPlayer mL = new();
        Console.WriteLine(mL.GetName);
        Console.WriteLine(mL.GetLevel);
        Console.WriteLine(mL.GetUsername("mbahgaul17"));
        Console.WriteLine("----------------------");
        KarambolPlayer karambol = new();
        Console.WriteLine(karambol.GetName("Master Karambol"));
        Console.WriteLine(karambol.GetID);
    }
}