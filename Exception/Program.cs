class Program
{
    static void Main()
    {
        // int[] array = { 1, 2, 3 };
        // int x = array[10];
        // Console.WriteLine(x); // ! Exception Out of Range

        // Handle Exception with Try Catch

        // string parse = "12a";
        // bool parsingStatus = int.TryParse(parse, out int result); // ? Better than using TryCatch
        // Console.WriteLine(parsingStatus);
        // Console.WriteLine(result);


        int x = 10;

        Console.WriteLine("Execute Code ------\n");

        try
        {
            Console.WriteLine(x / 0);
            Console.WriteLine("Code Execution Successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error : {e.Message}\nError Exception Handle. please Check Your Code!");
        }


    }
}