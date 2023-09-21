namespace Cars;

public interface IElectricEngine : IEngine, IElectric
{
    void NotifyFuel();
}
