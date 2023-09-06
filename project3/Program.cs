using Cars;
public static class Programs
{
    public static void Main()
    {
        DieselEngine diesel = new DieselEngine();
        ElectricalEngine electrical = new ElectricalEngine();
        HamsterEngine hamster = new HamsterEngine();
        Car car= new Car(diesel);

        Console.WriteLine("Lets Go!");
        car.StartEngine();
        diesel.EngineRun();
        electrical.EngineRun();
        hamster.EngineRun();

    }
}
