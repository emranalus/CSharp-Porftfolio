using MediatorPattern.Lab3.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab3.Mediator.Concrete
{
    abstract class Firm
    {

        protected ITransport transport;

        public Firm(ITransport _transport)
        {
            transport = _transport;
        }

        public abstract void StartShipping();

    }
}
