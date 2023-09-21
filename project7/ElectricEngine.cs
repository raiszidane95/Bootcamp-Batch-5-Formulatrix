namespace Cars;

public class ElectricEngine : IElectricEngine, IEngine
{
    public bool isCharging = false;


    public void Charge()
    {
        Console.WriteLine("Is Charging");
    }

    public void EngineRun()
    {
        Console.WriteLine("Electric Engine Runing");
    }

    public void EngineStop()
    {
        Console.WriteLine("Electric Engine Stop");
    }

    public void NotifyFuel()
    {

    }

}
