

namespace Event_Handler_with_EvenArgs_data;

public class Youtuber
{
    public EventHandler<EventData>? subscriber;
    private string _name;

    public Youtuber(string name)
    {
        _name = name;
    }

    public void UploadVideo()
    {
        Console.WriteLine($"Uploading Video");
        SendNotification();
    }

    public void SendNotification()
    {
        if (subscriber != null)
        {
            subscriber.Invoke(this, new EventData { Id = 1, message = "Uploaded Video" });
        }
    }
    public override string ToString()
    {
        return _name;
    }
}
