using BookEntity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BookEntity.Concrete
{
    public class Book : BaseItem<int>
    {

        public override int Id { get; set; }
        [Required(ErrorMessage = "Book must have a title!")]
        [MaxLength(200)]
        public string Title { get; set; }
        [Range(0, 100000, ErrorMessage = "Price must be between 0 and 100.000")]
        public double Price { get; set; }

        // One book has one Genre
        public string GenreId { get; set; }
        public Genre Genre { get; set; }

        public IList<BooksAuthors> BooksAuthors { get; set; }

    }
}
