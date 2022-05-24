using CreationalDesignPattern.Abstract;
using CreationalDesignPattern.Creator;
using System;

namespace CreationalDesignPattern
{
    class Program
    {

        public IProduct product;
        ProductCreator productCreator = new ProductCreator();

        static void Main(string[] args)
        {

            IProduct product;
            ProductCreator productCreator = new ProductCreator();

            for (int i = 1; i < 13; i++)
            {
                product = productCreator.FactoryMethod(i);
                Console.WriteLine(product.ShipFrom());
            }
        }
    }
}
