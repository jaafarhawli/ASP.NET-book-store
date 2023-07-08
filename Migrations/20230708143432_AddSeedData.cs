using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineBookstore.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "Bio", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Harper Lee, known as Nelle, was born in the Alabama town of Monroeville, the youngest of four children of Amasa Coleman Lee and Frances Cunningham Finch Lee.", "Harper", "Lee" },
                    { 2, "George Orwell, pseudonym of Eric Arthur Blair, was an English novelist, essayist, and critic famous for his novels Animal Farm (1945) and Nineteen Eighty-four (1949).", "George", "Orwell" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[,]
                {
                    { 1, "Southern Gothic" },
                    { 2, "Dystopian" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "Address", "PublisherName" },
                values: new object[,]
                {
                    { 1, "1290 Avenue of the Americas, New York, NY 10104, USA", "Grand Central Publishing" },
                    { 2, "375 Hudson St, New York, NY 10014, USA", "Signet Classics" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "ContactNumber", "Email", "FirstName", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "123 Main St, Anytown, USA", "1234567890", "alice@example.com", "Alice", "Smith", "Password1", "Alice" },
                    { 2, "456 Oak St, Anytown, USA", "2345678901", "bob@example.com", "Bob", "Johnson", "Password2", "Bob" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "GenreID", "ISBN", "Price", "PublicationDate", "PublisherID", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "9780446310789", 7.99m, new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "To Kill a Mockingbird" },
                    { 2, 2, 2, "9780451524935", 8.99m, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "1984" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderDate", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.99m, 1 },
                    { 2, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.98m, 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "BookID", "OrderID", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 7.99m, 1 },
                    { 2, 2, 2, 8.99m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "BookID", "Rating", "ReviewDate", "ReviewText", "UserID" },
                values: new object[,]
                {
                    { 1, 1, 5, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A timeless classic. Everyone should read this book.", 1 },
                    { 2, 2, 4, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A chilling vision of the future. Highly recommended.", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);
        }
    }
}
