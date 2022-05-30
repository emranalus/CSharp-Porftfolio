using EntitiyFWBeginner.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFWBeginner.Model.Concrete
{
    public class Category : BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        
        // One to many relationship
        public List<Product> products { get; set; }
        
    }
}
