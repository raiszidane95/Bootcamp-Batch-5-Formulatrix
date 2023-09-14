namespace EventHandlerClass;
class Youtuber
{
    public EventHandler subscriber;
    private string _name;

    public Youtuber(string name)
    {
        _name = name;
    }

    public void UploadingVideo()
    {
        Console.WriteLine($"Uploading Video");
        SentNotification();

    }

    public void SentNotification()
    {
        if (subscriber != null)
        {
            subscriber.Invoke(_name, EventArgs.Empty);
        }
    }



}
