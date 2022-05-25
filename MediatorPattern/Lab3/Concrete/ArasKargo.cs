using MediatorPattern.Lab3.Mediator.Abstract;
using MediatorPattern.Lab3.Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab3.Concrete
{
    class ArasKargo : Firm
    {

        public ArasKargo(ITransport transport) : base(transport)
        {

        }

        public override void StartShipping()
        {
            Console.WriteLine("Aras kargo Igdirdan esyalari yukledi!");
            transport.ShipCargo(this);
        }
    }
}
