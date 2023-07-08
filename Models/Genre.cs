// Models/Genre.cs
namespace OnlineBookstore.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}

