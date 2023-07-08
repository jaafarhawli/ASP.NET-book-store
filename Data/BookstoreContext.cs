using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Models;

public class BookstoreContext : DbContext
{
    public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { BookID = 1, Title = "To Kill a Mockingbird", AuthorID = 1, GenreID = 1, Price = 7.99m, ISBN = "9780446310789", PublisherID = 1, PublicationDate = new DateTime(1960, 7, 11) },
            new Book { BookID = 2, Title = "1984", AuthorID = 2, GenreID = 2, Price = 8.99m, ISBN = "9780451524935", PublisherID = 2, PublicationDate = new DateTime(1949, 6, 8) }
        );

        modelBuilder.Entity<Author>().HasData(
            new Author { AuthorID = 1, FirstName = "Harper", LastName = "Lee", Bio = "Harper Lee, known as Nelle, was born in the Alabama town of Monroeville, the youngest of four children of Amasa Coleman Lee and Frances Cunningham Finch Lee." },
            new Author { AuthorID = 2, FirstName = "George", LastName = "Orwell", Bio = "George Orwell, pseudonym of Eric Arthur Blair, was an English novelist, essayist, and critic famous for his novels Animal Farm (1945) and Nineteen Eighty-four (1949)." }
        );

        modelBuilder.Entity<Genre>().HasData(
            new Genre { GenreID = 1, GenreName = "Southern Gothic" },
            new Genre { GenreID = 2, GenreName = "Dystopian" }
        );

        modelBuilder.Entity<Publisher>().HasData(
            new Publisher { PublisherID = 1, PublisherName = "Grand Central Publishing", Address = "1290 Avenue of the Americas, New York, NY 10104, USA" },
            new Publisher { PublisherID = 2, PublisherName = "Signet Classics", Address = "375 Hudson St, New York, NY 10014, USA" }
        );

        modelBuilder.Entity<User>().HasData(
            new User { UserID = 1, Username = "Alice", Password = "Password1", Email = "alice@example.com", FirstName = "Alice", LastName = "Smith", Address = "123 Main St, Anytown, USA", ContactNumber = "1234567890" },
            new User { UserID = 2, Username = "Bob", Password = "Password2", Email = "bob@example.com", FirstName = "Bob", LastName = "Johnson", Address = "456 Oak St, Anytown, USA", ContactNumber = "2345678901" }
        );

        modelBuilder.Entity<Order>().HasData(
            new Order { OrderID = 1, UserID = 1, OrderDate = new DateTime(2023, 1, 1), TotalPrice = 7.99m },
            new Order { OrderID = 2, UserID = 2, OrderDate = new DateTime(2023, 2, 2), TotalPrice = 17.98m }
        );

        modelBuilder.Entity<OrderDetail>().HasData(
            new OrderDetail { OrderDetailID = 1, OrderID = 1, BookID = 1, Quantity = 1, Price = 7.99m },
            new OrderDetail { OrderDetailID = 2, OrderID = 2, BookID = 2, Quantity = 2, Price = 8.99m }
        );

        modelBuilder.Entity<Review>().HasData(
            new Review { ReviewID = 1, UserID = 1, BookID = 1, Rating = 5, ReviewText = "A timeless classic. Everyone should read this book.", ReviewDate = new DateTime(2023, 1, 2) },
            new Review { ReviewID = 2, UserID = 2, BookID = 2, Rating = 4, ReviewText = "A chilling vision of the future. Highly recommended.", ReviewDate = new DateTime(2023, 2, 3) }
        );
    }

}

