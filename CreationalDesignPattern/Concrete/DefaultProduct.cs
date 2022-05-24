using CreationalDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.Concrete
{
    class DefaultProduct : IProduct
    {
        public string ShipFrom()
        {
            return "Yurt ici";
        }
    }
}
