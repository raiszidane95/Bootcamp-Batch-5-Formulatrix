using System.Threading.Tasks.Dataflow;

namespace Cars;

public class Car
{
    public string? name;
    public Engine? engine;
    public string? fuelType;
    public int fuelCapacity;
    public string? brand;

    // Constructor with no required parameter
    public Car(Engine engine)
    {
    }

    // Constructor with all required parameter of variable
    public Car(Engine engine, string name, string fuelType, int fuelCapacity, string brand)
    {
        this.engine = engine;
        this.name = name;
        this.fuelType = fuelType;
        this.fuelCapacity = fuelCapacity;
        this.brand = brand;
    }

    public Car(string name, string fuelType, string brand)
    {
        this.name = name;
        this.fuelType = fuelType;
        this.brand = brand;
    }


}
