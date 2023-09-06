/*
    Interface
*/

using Cars;

public class Program
{
    public static void Main()
    {
        DieselEngine diesel = new();
        diesel.EngineStop();
        diesel.EngineRun();

        Console.WriteLine("---------  ---------");

        ElectricEngine electric = new();
        electric.isCharging = true;

        if (electric.isCharging == true)
        {
            electric.EngineStop();
        }
        else
        {
            electric.EngineRun();
        }
    }
}