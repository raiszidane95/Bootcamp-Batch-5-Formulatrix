using TwelveMonth;

public class Program
{
    public static void Main()
    {
        Month[] months = (Month[])Enum.GetValues(typeof(Month)); //Get Array of Enum
        foreach (var month in months)
        {
            Console.WriteLine($"planet : {month.ToString()} index : {(int)month}");
        }

        string[] monthsInString = Enum.GetNames(typeof(Month)); //Get Array of String
        foreach (var m in monthsInString)
        {
            Console.WriteLine(m);

        }

        string monthx = (Month.August & Month.September).ToString();
        Console.WriteLine(monthx);


        EnumPrinter(Month.February);
    }

    static void EnumPrinter(Month m)
    {
        Console.WriteLine(m.ToString());
        Console.WriteLine((int)m);

    }
}