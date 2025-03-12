namespace modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //table driven dengan mengambil kelas kodeproduk di metode getKodeProduk
            KodeProduk produk = new KodeProduk();
            Console.Write("Masukkan nama produk: ");
            string elek = Console.ReadLine();
            string kodeProd = produk.getKodeProduk(elek);
            Console.WriteLine($"Kode Produk {elek} : {kodeProd}");

            //membuat objek dan memanggil tiap state dengan urutan sesuai transition di jurnal
            FanLaptop fan = new FanLaptop();
            fan.Mode_Up();
            fan.Mode_Down(); 
            fan.Turbo_Shortcut();
            fan.Mode_Down2();
            fan.Mode_Up2();
        }
    }
}
