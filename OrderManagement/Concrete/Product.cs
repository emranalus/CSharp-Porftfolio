using OrderManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Concrete
{
    public class Product : BaseEntity
    {

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

    }
}
