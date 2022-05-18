using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    internal class Kare : Dikdortgen
    {
        private int _kisaKenar;

        public int KisaKenar
        {
            get { return _kisaKenar; }
            set { _kisaKenar = value; }
        }

        private int _uzunKenar;

        public int UzunKenar
        {
            get { return _uzunKenar; }
            set { _uzunKenar = value; }
        }



    }
}
