using ChainOfResponsibility.Lab2.Abstract;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Lab2.Concrete
{
    class CEO : CostManagement
    {
        public override void ManageCosts(Cost cost)
        {
            if (cost.Amount >= 500 && cost.Amount < 5000)
            {
                Console.WriteLine("This cost has been generated bu the CEO of the company!");
            }
            else if (cost.Amount >= 5000)
            {
                Console.WriteLine("Did you just sold the damn company!!!");
            }
        }
    }
}
