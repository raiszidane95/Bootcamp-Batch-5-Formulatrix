namespace EventHandlerClass;
class Subscriber
{
    public void Notification(object sender, EventArgs args)
    {
        Console.WriteLine($"Get Notification from {sender}");

    }
}
