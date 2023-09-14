using System.Collections;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3 }; // list of int 

        foreach (int item in list) // foreach Iterator
        {
            Console.WriteLine(item);
        }

        IEnumerator iterator = list.GetEnumerator(); // access iterator of list 
        while (iterator.MoveNext())                  // iteration process
        {
            Console.WriteLine(iterator.Current);
        }
        iterator.Reset();
        iterator.MoveNext();
        Console.WriteLine(iterator.Current);
    }
}