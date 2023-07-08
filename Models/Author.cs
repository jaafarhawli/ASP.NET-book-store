// Models/Author.cs
namespace OnlineBookstore.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }

        // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}

