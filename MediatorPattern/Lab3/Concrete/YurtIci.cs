using MediatorPattern.Lab3.Mediator.Abstract;
using MediatorPattern.Lab3.Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab3.Concrete
{
    class YurtIci : Firm
    {

        public YurtIci(ITransport transport) : base(transport)
        {

        }

        public override void StartShipping()
        {
            Console.WriteLine("Ankaradan kargo yuklendi!");
            transport.ShipCargo(this);
        }
    }
}
