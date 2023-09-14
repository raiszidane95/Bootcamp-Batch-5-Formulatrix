class Program
{
    static void Main()
    {
        ProcessBussinessLogic bl = new ProcessBussinessLogic();
        bl.ProcessCompleted += BL_ProcessCompleted;
        bl.StartProcess();
    }

    public static void BL_ProcessCompleted(object sender, ProcessEventArgs eventArgs)
    {
        Console.WriteLine($"Sender is");
        
        Console.WriteLine("Process " + (eventArgs.IsSuccessful ? "Completed Successfully" : "failed"));
        Console.WriteLine("Completion Time: " + eventArgs.CompletionTime.ToLongDateString());
    }
}
class ProcessBussinessLogic
{
    //delegate with built-in delegate 
    public event EventHandler<ProcessEventArgs>? ProcessCompleted;

    public void StartProcess()
    {
        var data = new ProcessEventArgs();

        try
        {
            Console.WriteLine("Process Stated!");
            data.IsSuccessful = true;
            data.CompletionTime = DateTime.Now;
            OnProcessCompleted(this, data);  //No event data
        }
        catch (Exception e)
        {
            data.IsSuccessful = false;
            data.CompletionTime = DateTime.Now;
            OnProcessCompleted(this, data); 
        }
    }

    protected void OnProcessCompleted(object? sender, ProcessEventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }

}

class ProcessEventArgs : EventArgs
{
    public bool IsSuccessful;
    public DateTime CompletionTime;
}