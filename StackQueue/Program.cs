using System.ComponentModel;

class Program
{
    static void Main()
    {
        //First In First Out (FIFO) 
        Antrian.AmbilAntrian("Budi");
        Antrian.AmbilAntrian("Nana");
        Antrian.AmbilAntrian("Vero");
        Antrian.AntrianSelesai();

        string[] arrayQueue = Antrian.q.ToArray();
        Console.WriteLine("Antrian saat ini adalah " + Antrian.LihatAntrianSekarang()); // Peeking the First Queue
        foreach (var item in arrayQueue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"---------------------- ");

        //Last In First Out (LIFO) 
        Tumpukan.Tumpuk("Phsycology of Money");
        Tumpukan.Tumpuk("Atomic habbit");
        Tumpukan.Tumpuk("Rich Dad, Poor Dad");
        Tumpukan.Ambil();

        string[] arrayStack = Tumpukan.buku.ToArray();
        Console.WriteLine("Tumpukan buku paling atas " + Tumpukan.BukuPalingAtas()); // Peeking the First Queue
        int x = 1;
        foreach (var item in arrayStack)
        {

            Console.WriteLine(x++ + ". " + item);
        }

    }
}


