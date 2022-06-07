using BookEntity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Concrete
{
    public class Genre : BaseItem<string>
    {

        [MaxLength(10)]
        [Required(ErrorMessage = "Id is not optional!")]
        public override string Id { get; set; }
        [Required(ErrorMessage = "Genre name is not optional!")]
        [MaxLength(50)]
        public string Name { get; set; }

        public IList<Book> Books { get; set; }

    }
}
