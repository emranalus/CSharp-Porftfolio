using OrderManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Concrete
{
    public class Customer : BaseEntity
    {

        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }

    }
}
