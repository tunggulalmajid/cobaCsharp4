using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coba_Csharp_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mobil Daihatsu = new mobil();
            Daihatsu.klakson();
            Daihatsu.jenis = "Xenia";
            Daihatsu.warna = "Hitam";
            Daihatsu.kecepatan = 50;
            int harga = Daihatsu.getHarga();
            harga = Daihatsu.setHarga(5000000);

            Console.WriteLine("mobil Daihatsu berjenis >> {0}", Daihatsu.jenis);
            Console.WriteLine("mobil Daihatsu berwarna >> {0}", Daihatsu.warna);
            Console.WriteLine("Kecepatan mobil Daihatsu adalah >> {0} km/jam", Daihatsu.kecepatan);
            Console.WriteLine("harga mobil daihatsu >> Rp. {0}", harga);

            //mobil toyota = new mobil();
            //toyota.klakson();
            //toyota.jenis = "Avanza";
            //toyota.warna = "Putih";
            //toyota.kecepatan = 40;
            //Console.WriteLine("mobil Toyota berjenis >> {0}", toyota.jenis);
            //Console.WriteLine("mobil Toyota berwarna >> {0}", toyota.warna);
            //Console.WriteLine("Kecepatan mobil Toyota adalah >> {0} km/jam", toyota.kecepatan);
            
        }
    }

}
