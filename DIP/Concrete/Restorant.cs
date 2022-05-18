using DIP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Concrete
{
    internal class Restorant
    {

        List<IYemek> _yemeks;

        public Restorant(List<IYemek> yemekler)
        {
            _yemeks = yemekler;
        }

        public void YemekleriPisir()
        {
            foreach (var yemek in _yemeks)
            {
                yemek.Pisir();
            }
        }

    }
}
