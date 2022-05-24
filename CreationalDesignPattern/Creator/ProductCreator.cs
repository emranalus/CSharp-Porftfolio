using CreationalDesignPattern.Abstract;
using CreationalDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern.Creator
{
    class ProductCreator
    {

        public IProduct FactoryMethod(int ay)
        {
            if (ay == 1 || ay == 3 || ay == 6)
            {
                return new ProductA();
            }
            else if(ay == 2 || ay == 4 || ay == 5)
            {
                return new ProductB();
            }
            else
            {
                return new DefaultProduct();
            }
        }

    }
}
