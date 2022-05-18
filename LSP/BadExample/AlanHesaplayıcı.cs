using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    internal class AlanHesaplayıcı
    {

        public int AlanHesapla(Dikdortgen dikdortgen)
        {
            return dikdortgen.KisaKenar * dikdortgen.UzunKenar;
        }

        public int AlanHesapla(Kare kare)
        {
            return kare.KisaKenar * kare.UzunKenar;
        }

    }
}
