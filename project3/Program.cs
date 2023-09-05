using Cars;
public static class Programs
{
    public static void Main()
    {
        DieselEngine diesel = new DieselEngine();
        ElectricalEngine electrical = new ElectricalEngine();
        HamsterEngine hamster = new HamsterEngine();

        Console.WriteLine("Lets Go!");
        diesel.EngineRun();
        electrical.EngineRun();
        hamster.EngineRun();

    }
}
