namespace OnlineBookstore.Models
{
    // Models/Book.cs
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public int PublisherID { get; set; }
        public DateTime PublicationDate { get; set; }

        // Navigation properties
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
