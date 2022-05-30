using LibraryPractice.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice.Concrete
{
    public class Author : BaseContext
    {

        [MaxLength(50)]
        public string AuthorName { get; set; }

        [MaxLength(50)]
        public string AuthorSurname { get; set; }
        public bool Sex { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
