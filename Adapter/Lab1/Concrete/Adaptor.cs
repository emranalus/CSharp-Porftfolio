using Adapter.Lab1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Lab1.Concrete
{
    class Adaptor : Organizer, ITarget
    {
        public string Request(int i)
        {
            return $"Tahmini Sonuc: { Math.Round(SpecialRequest(i,3)) }";
        }

    }
}
