namespace modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeProduk produk = new KodeProduk();
            Console.Write("Masukkan nama produk: ");
            string elek = Console.ReadLine();
            string kodeProd = produk.getKodeProduk(elek);

        }
    }
}
