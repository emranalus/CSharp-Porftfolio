using OCP.GoodCoffee.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GoodCoffee.Concrete
{
    internal class TurkishCoffee : GoodCoffeeShop
    {
        public override double GetTotalPrice(int adet)
        {
            return adet * 20;
        }
    }
}
