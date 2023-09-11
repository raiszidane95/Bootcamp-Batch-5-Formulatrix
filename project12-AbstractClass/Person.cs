namespace Persons;

public abstract class Person
{
    public string? name { get; set; }
    public string? address { get; set; }

    public virtual void GetName(string name)
    {
        this.name = name;
    }

    public abstract void DoingSomething();

    public void Eat()
    {
        Console.WriteLine("Employee doing Something");


    }
}

public class Customer : Person
{
    public int number;
    public override void DoingSomething()
    {
        Console.WriteLine("Customer Doing Something..");
    }

    public void Buy()
    {
        Console.WriteLine("Customer buy something..");
    }
}

public class Employee : Person
{
    public override void DoingSomething()
    {
        Console.WriteLine("Employee doing Something");
        
    }

    public override void GetName(string name)
    {
        Console.WriteLine(name);

    }

    public void Work()
    {
        Console.WriteLine("Employee doing Work..");

    }
}