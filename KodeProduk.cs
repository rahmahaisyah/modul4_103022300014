using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul4
{
    public class KodeProduk
    {
        private static Dictionary<string, string> produkElek = new Dictionary<string, string>
        {
            { "Laptop", "E100"},
            {"Smartphone", "E101" },
            {"Tablet" , "E102"},
            { "Headset", "E103"},
            {"Keyboard",  "E104"},
            { "Mouse", "E105"},
            {"Printer", "E106" },
            { "Monitor", "E107"},
            { "Smartwatch", "E108"},
            {"Kamera", "E109" }
        };
        /*
         * using System.Collections.Generic; → Digunakan untuk mendukung Dictionary<>,
yang merupakan struktur data berbasis key-value pair.B. Memanggil Method di Main
- Dictionary<string, string> → Menyimpan pasangan nama produk (key) dan kode
pos (value).
- Data disimpan dalam bentuk key-value, sehingga pencarian kode produk menjadi cepat
dan efisien.
         */
        public string getKodeProduk(string produk) {

            return produkElek.ContainsKey(produk) ? produkElek[produk] : "produk tidak ditemukan";
        }

    }
}
 
 
 
 
 
 
 
 
 
 