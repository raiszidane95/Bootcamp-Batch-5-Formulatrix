using DelegateWithReturnValue;

public delegate void DelegateMethod(string x);
class Program
{

    static void Main()
    {
        Car car1 = new Car();
        Human rais = new Human();


        DelegateMethod myDel = car1.EngineRun;
        myDel += rais.Eat;

        Invoker(myDel, "Hello World");
    }
    static void Invoker(DelegateMethod delegateMethod, string str)
    {
        delegateMethod.Invoke(str);
    }
}

