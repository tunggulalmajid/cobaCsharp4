using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coba_Csharp_4
{
    class raja
    {
        private string istri = "Ruri   ";
        private int kekayaan = 1000;
        
        //penulisan 1
        // hanya get
        public string Istri
        {
            get { return istri; }
        }

        // get set penulisan 1 
        public int Kekayaan 
        {
            get { return kekayaan; }
            set { 
                if (value > 1000) 
                kekayaan = value; 
                }
        }

        // penulisan get set kedua
        public int luasWilayah { get; set; }






    }
}
