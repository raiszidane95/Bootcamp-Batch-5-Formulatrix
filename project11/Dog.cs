

//static = non instance/ non object
//method static -> static variable or another static method
//static -x-> instance
//instance --> static
// static => variable, method, class
// static class  { static method, static variable }
// class { method, static method, static variable, variable }

namespace Animals;
class Dog 
{
	public static string? name;
	public int age;
	public Dog(string names, int age) {
		 name = names;
		 this.age = age;
	}
	public static void Eat() //static --> static
	{
        Console.WriteLine("Eat");
		Console.WriteLine(name); //name is static
		//age.Dump(); Age is non static
	}
	public string GetName() //instance --> static || instance
	{
		return name;
	}
	public int GetAge() 
	{
		return age;
	}
}
