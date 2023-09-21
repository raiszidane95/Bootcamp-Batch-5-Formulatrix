class Tumpukan
{
    public static Stack<string> buku = new Stack<string>();

    public static void Tumpuk(string x)
    {
        buku.Push(x);
    }
    public static void Ambil()
    {
        buku.Pop();
    }
    public static string BukuPalingAtas()
    {
        return buku.Peek();
    }
}
