using CreationalDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.Concrete
{
    class ProductA : IProduct
    {
        public string ShipFrom()
        {
            return "Avrupa";
        }
    }
}
