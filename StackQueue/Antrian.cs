class Antrian
{

    public static Queue<string> q = new Queue<string>();
    public static void AmbilAntrian(string x)
    {
        q.Enqueue(x);
    }

    public static void AntrianSelesai()
    {
        q.Dequeue();
    }

    public static string LihatAntrianSekarang()
    {
        return q.Peek();
    }
}
