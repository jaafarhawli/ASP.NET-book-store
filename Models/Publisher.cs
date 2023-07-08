// Models/Publisher.cs
namespace OnlineBookstore.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }
        public string Address { get; set; }

        // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}

