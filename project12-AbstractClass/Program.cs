

using Animals;
using Persons;
public class Programs
{
    public static void Main()
    {
        Cat cat = new Cat();
        cat.MakeSound();
        cat.Eat();
        cat.sleep();

        Console.WriteLine("---------- Batas ----------");

        Dog dog = new Dog();
        dog.MakeSound();
        dog.Eat();
        dog.sleep();


        Console.WriteLine("---------- Batas ----------");

        Employee bayu = new Employee();
        bayu.GetName("bayu");
        bayu.DoingSomething();

        Customer customer = new Customer();
        customer.DoingSomething();

    }
}