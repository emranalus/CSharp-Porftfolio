using CreationalDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.Concrete
{
    class ProductC : IProduct
    {
        public string ShipFrom()
        {
            return "Asya";
        }
    }
}
