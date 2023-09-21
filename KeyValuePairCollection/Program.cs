
using System.Collections;

class Program
{
    static void Main()
    {
        // Dictionary
        Dictionary<int, string> dict = new();
        dict.Add(12, "Haloo");
        dict.TryAdd(0, "Nol"); // Adding with checking if key is not null -> if there is a same key it will not be added
        dict.TryGetValue(2, out string? str);

        // HashTable
        Hashtable hashtable = new();
        hashtable.Add(12, 14);
        hashtable.Add("String", false);
        hashtable.Add(true, "string true");

        // Dictionary

        Console.WriteLine($"\nDictionary");
        Console.WriteLine($"{dict[0]}");
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} is {item.Value}");
        }
        Console.WriteLine(str);

        // HashTable
        Console.WriteLine($"\n-----HashTable-----");
        Console.WriteLine(hashtable[true]);
        Console.WriteLine(hashtable["String"]);
        Console.WriteLine(hashtable[12]);
    }
}

