using System.Collections;
using System.Runtime.CompilerServices;

class Program
{ 
    static void Main()
    {
        /* Array */
        int[] arrays = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int callIndexValue = arrays[9];
        System.Console.WriteLine($"call {callIndexValue} \n");

        /* Array List*/

        ArrayList arrayLists = new ArrayList();
        arrayLists.Add(10);
        arrayLists.Add(false);
        arrayLists.Add("String");

        /* List */
        List<int> list = new List<int>();
        list.Add(12);
        list.Add(11);
        list.Add(43);
        list.Add(3);

        // HashSet<T>
        HashSet<int> set = new() { 10, 12, 5 };
        HashSet<int> set2 = new() { 1, 10, 5, 4 };
        int first = set.First();
        set.Add(13);



        /*-------- Print ------*/

        // Array List
        Console.WriteLine(arrayLists[1] + "\n");

        // List 
        Console.WriteLine("Value list of index 2 = " + list[2]);


        // HashSet
        Console.WriteLine($"\nHashSet");
        Console.WriteLine(first);
    }

}