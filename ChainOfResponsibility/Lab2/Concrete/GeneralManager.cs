using ChainOfResponsibility.Lab2.Abstract;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Lab2.Concrete
{
    class GeneralManager : CostManagement
    {
        public override void ManageCosts(Cost cost)
        {
            if(cost.Amount <= 500)
            {
                Console.WriteLine("This cost has been generated by the General Manager!");
            }
            else if (_next!=null)
            {
                _next.ManageCosts(cost);
            }
        }
    }
}
