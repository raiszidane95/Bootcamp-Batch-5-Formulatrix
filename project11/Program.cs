// Upcast Downcast Instance

//Casting Child -> Parent -> Chid (Bisa)
//Parent -> Child (InvalidCastException)

using Animals;

public class Programs
{
    public static void Main()
    {
        Console.WriteLine("Hello World \n");
        // Animal animal = new Animal();
        // Cat cat = (Cat)animal; // Exception on this because cannot cast Animal.animal to Animal.Cat

        // cat.MakeSound();
        // cat.Eat();


        Cat origin = new Cat();
        Animal animal1 = origin;
        Cat cat1 = (Cat)animal1; // this can Casting instance because from the instance of 'cat' is casting by parent class which the child class have a complete property and method

        cat1.MakeSound();
        animal1.MakeSound();

        Console.WriteLine("");
        Dog dog1 = new Dog("burhan", 22);
        Dog dog2 = new Dog("cibi", 20);

        Console.WriteLine(dog1.GetName()); // burhan -> cibi (its change to cibi because static is share able)
        Console.WriteLine(dog1.GetAge()); // 22

        Console.WriteLine(dog2.GetName()); // cibi
        Console.WriteLine(dog2.GetAge()); // 22
    }
}