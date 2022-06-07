using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntity.Concrete
{
    // Composite Table
    public class BooksAuthors
    {
        // Bu
        public int BookId { get; set; }
        // Buna
        public Book Book { get; set; }

        // Bu
        public int AuthorId { get; set; }
        // Buna
        public Author Author { get; set; }

    }
}
