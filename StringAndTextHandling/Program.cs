class Program
{
    static void Main()
    {
        string string1 = "Ariston Rais Zidane";

        char[] listString = string1.ToArray();
        foreach (char s in listString)
        {
            if (s == 'A' | s == 'a' | s == 'I' | s == 'i' | s == 'U' | s == 'u' | s == 'E' | s == 'E' | s == 'O' | s == 'o')
                Console.Write($"{s} ");
        }
    }
}