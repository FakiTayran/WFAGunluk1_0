using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAGunluk1_0
{
    class Yazi
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        public override string ToString()
        {
            return Baslik;
        }

    }
}
