namespace EventHandlerClass;

class Subscriber2
{
    public void Notification(object sender, EventArgs args)
    {
        Console.WriteLine($"Get Notification from {sender}");

    }
}