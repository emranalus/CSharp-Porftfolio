using MediatorPattern.Lab3.Mediator.Abstract;
using MediatorPattern.Lab3.Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab3.Concrete
{
    class MngKargo : Firm
    {

        public MngKargo(ITransport transport) : base(transport)
        {

        }

        public override void StartShipping()
        {
            Console.WriteLine("Sivastan kargo yuklendi!");
            transport.ShipCargo(this);
        }
    }
}
