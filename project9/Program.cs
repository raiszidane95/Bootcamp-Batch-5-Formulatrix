public class Program
{
    public static void Main()
    {
        //Upcast = small size type -> big size type
        //Implicit
        int x = 9; //4 byte / 32 bit
        double y = x; //8 byte

        //Downcast = big size type -> small size type
        //Explicit
        double z = 10000000000;
        int q = (int)z; //Explicit cast

        Console.WriteLine(x);
        Console.WriteLine(q);
    }
}