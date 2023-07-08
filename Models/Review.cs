// Models/Review.cs
namespace OnlineBookstore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
