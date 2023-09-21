/*
    Interface Seggregation Principle
*/

using Game;

public class Program
{
    public static void Main()
    {
        MobileLegendPlayer mL = new();
        Console.WriteLine("Name = " + mL.GetName("Muzzamie Arra"));
        Console.WriteLine("Id = " + mL.GetID(65));
        Console.WriteLine("Level = " + mL.GetLevel());
        Console.WriteLine("Username = " + mL.GetUsername("mbahgaul17"));
        Console.WriteLine("----------------------");
        KarambolPlayer karambol = new();
        Console.WriteLine(karambol.GetName("Master Karambol"));
        Console.WriteLine(karambol.GetID(13));
    }
}