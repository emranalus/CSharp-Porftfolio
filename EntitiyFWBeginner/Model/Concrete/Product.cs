using EntitiyFWBeginner.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFWBeginner.Model.Concrete
{
    public class Product : BaseEntity
    {

        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        // Part that will be shown in the database 
        // as a foreign key
        public int CategoryId { get; set; }

        // Part that will be used as navigation property
        // This part will not be stored in the db as a field
        public Category category { get; set; }

    }
}
