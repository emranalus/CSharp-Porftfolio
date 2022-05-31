using EF_PracticeLearnt.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_PracticeLearnt.Concrete
{
    public class Author : BaseEntity
    {

        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }

        // One author can write as many books as he/she likes
        public virtual ICollection<Book> Books { get; set; }

    }
}
