using BookEntity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Concrete
{
    public class Author : BaseItem<int>
    {
        public override int Id { get; set; }

        [Required(ErrorMessage = "Name is not optional!")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname is not optional!")]
        [MaxLength(50)]
        public string Surname { get; set; }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }

        public IList<BooksAuthors> BooksAuthors { get; set; }

    }
}
