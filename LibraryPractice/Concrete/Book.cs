using LibraryPractice.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice.Concrete
{

    public enum Kind
    {
        Novel,
        Poetry,
        Memory,
        Story,
        Science,
        History
    }

    public class Book : BaseContext
    {

        public string BookName { get; set; }
        public string Description { get; set; }

        // One-To-Many Connection
        public int AuthorId { get; set; }

        public Author author { get; set; }
        public Kind kind { get; set; }

    }
}
