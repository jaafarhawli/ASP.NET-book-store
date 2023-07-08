// Models/Order.cs
namespace OnlineBookstore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

