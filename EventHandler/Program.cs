using EventHandlerClass;
class Program
{
    static void Main()
    {
        Youtuber youtuberYanto = new Youtuber("Yanto");
        Youtuber youtuberJessnolimit = new Youtuber("Jess No limit");

        Subscriber subscriber = new Subscriber();
        Subscriber2 subscriber2 = new Subscriber2();

        youtuberYanto.subscriber += subscriber.Notification;
        youtuberYanto.subscriber += subscriber.Notification;
        youtuberYanto.subscriber -= subscriber2.Notification; // Remove method event handler
        youtuberYanto.UploadingVideo(); // invocation Method

        youtuberJessnolimit.subscriber += subscriber2.Notification;
        youtuberJessnolimit.subscriber -= subscriber.Notification;
        youtuberJessnolimit.UploadingVideo();
    }
}
