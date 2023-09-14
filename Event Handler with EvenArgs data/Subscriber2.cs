namespace Event_Handler_with_EvenArgs_data;

public class Subscriber2
{
    public void Notification(object sender, EventData e)
    {
        Console.WriteLine($"{e.Id} Get Notif From {sender}");
    }
}
