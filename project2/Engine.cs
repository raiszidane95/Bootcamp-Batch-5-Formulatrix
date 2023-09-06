namespace Cars;

public class Engine
{
    public int torque;
    public int cylinder;
    public int cylinderCapacity;

    public Engine(int torque, int cylinder, int cylinderCapacity) // Constructor
    {
        this.torque = torque;
        this.cylinder = cylinder;
        this.cylinderCapacity = cylinderCapacity;
    }
}
