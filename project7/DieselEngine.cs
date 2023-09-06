using System.Net.Http.Headers;
namespace Cars;

public class DieselEngine : IEngine
{
    public void EngineRun()
    {
        Console.WriteLine("Diesel Engine Run..");
    }

    public void EngineStop()
    {
        Console.WriteLine("Diesel Engine stop..");
    }
}
