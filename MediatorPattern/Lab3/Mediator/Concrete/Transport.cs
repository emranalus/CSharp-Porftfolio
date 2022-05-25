using MediatorPattern.Lab3.Concrete;
using MediatorPattern.Lab3.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab3.Mediator.Concrete
{
    class Transport : ITransport
    {

        ArasKargo aras;
        MngKargo mng;
        YurtIci yurtici;

        public ArasKargo ArasKargo { set { aras = value; } }
        public MngKargo MngKargo { set { mng = value; } }
        public YurtIci YurticiKargo { set { yurtici = value; } }

        public void ShipCargo(Firm firma)
        {
            if (firma is ArasKargo)
            {
                Console.WriteLine("Aras Kargo Esyalari Sivas'a Birakti!");
                mng.StartShipping();
            }
            else if (firma is MngKargo)
            {
                Console.WriteLine("Mng Kargo Esyalari Ankara'ya Birakti!");
                yurtici.StartShipping();
            }
            else if (firma is YurtIci)
            {
                Console.WriteLine("Yurtici Kargo Esyalari Ankara'ya Birakti!");
                Console.WriteLine("Teslimat adrese ulasti!");
            }
        }
    }
}
