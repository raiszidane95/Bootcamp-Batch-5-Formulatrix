

namespace Animals
{
    public abstract class Animal
    {
        public string? name;
        public void Eat()
        {
            Console.WriteLine("Animal Eat");
        }
        public abstract void sleep(); // Wajib Override dari abstract method parent nya

        public virtual void MakeSound() // Tidak Wajib (dibebaskan) untuk di override pada inherit class nya
        {
            Console.WriteLine("Animal Sound");
        }
    }
    public class Cat : Animal
    {
        public override void sleep()  // Override dari abstract method parent nya
        {
            Console.WriteLine("Cat Sleep");
        }

    }

    public class Dog : Animal
    {
        public override void sleep() // Override dari abstract method parent nya
        {
            Console.WriteLine("Dog sleep");

        }
    }
}