using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coba_Csharp_4
{
    class mobil
    {
        public string warna;
        public string jenis;
        public int kecepatan;
        private int harga = 0;
        public void klakson()
        {
            Console.WriteLine("mberrr");
        }
        public int getHarga()
        {
            return harga;
        }
        public int setHarga(int hargaMobil) 
        {
            harga += hargaMobil;
            return harga;
        }
    }
}
