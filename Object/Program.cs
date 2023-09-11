public class Program
{
    public static void Main()
    {
        int x = 32;
        object y = x; //boxing

        int z = (int)y; //unboxing

        // int f = 33;
        // object g = f;
        // long l = (int)g;
        Console.WriteLine(z);

        // int angka = 100;
        object angka1 = 123;
        long angka3 = (int)angka1; // Must cast with explixcit casting
        Console.WriteLine(angka3);
    }
}