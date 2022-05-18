using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.BadExample
{

    public enum CoffeeType
    {
        Latte,
        Expresso,
        Nescafe
    }

    internal class BadCoffee
    {

        public double GetTotalPrice(int adet, CoffeeType coffee)
        {
            double totalPrice = 0;
            if (coffee == CoffeeType.Nescafe)
            {
                totalPrice = adet * 15;
            }
            else if (coffee == CoffeeType.Expresso)
            {
                totalPrice = adet * 20;
            }
            else if (coffee == CoffeeType.Latte)
            {
                totalPrice = adet * 25;
            }

            return totalPrice;
        }

    }
}
