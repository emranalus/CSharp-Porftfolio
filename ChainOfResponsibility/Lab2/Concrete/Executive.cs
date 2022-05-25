using ChainOfResponsibility.Lab2.Abstract;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Lab2.Concrete
{
    class Executive : CostManagement
    {
        public override void ManageCosts(Cost cost)
        {
            if (cost.Amount <= 100)
            {
                Console.WriteLine("Executive generated cost!");
            }
            else if (_next != null)
            {
                _next.ManageCosts(cost);
            }
        }
    }
}
