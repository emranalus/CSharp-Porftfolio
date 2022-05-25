using Adapter.Lab1.Abstract;
using Adapter.Lab1.Concrete;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Organizer organizer = new Organizer();
            Console.WriteLine(organizer.SpecialRequest(5,3));

            ITarget target = new Adaptor();

            Console.WriteLine(target.Request(5));
            

        }
    }
}
