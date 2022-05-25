using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Lab2.Abstract
{
    abstract class CostManagement
    {

        protected CostManagement _next;

        public void CostCenter(CostManagement next)
        {
            _next = next;
        }

        public abstract void ManageCosts(Cost cost);

    }
}
