using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Action<string, string> fireAlarmNotifier = FloorOne; // Add mehtod AddUser to Action
        Action<string, string> listAlarmNotify = fireAlarmNotifier += FloorTwo;

        Delegate[] delegates = listAlarmNotify.GetInvocationList();

        // fireAlarmNotifier.Invoke("Fire detected inside building", "Floor1"); // invoke void method with input string to each method 
        foreach (Action<string, string> delegator in delegates)
        {
            delegator.Invoke("Fire detected on this floor", "Floor2");
        }
    }

    static void FloorOne(string x, string y)
    {
        Console.WriteLine(x);
        Console.WriteLine(y);
    }

    static void FloorTwo(string x, string y)
    {
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}