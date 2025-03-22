using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class MakeProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products (Name, ImageUrl, Description, Price, ReleaseDate, CategoryId) " +
                   "VALUES ('Italian Cappuccino', 'cappuccino.jpg', 'A typical italian coffee', 4.20, NOW(), 1)");

            mb.Sql("INSERT INTO Products (Name, ImageUrl, Description, Price, ReleaseDate, CategoryId) " +
                   "VALUES ('Orange Juice', 'orangejuice.jpg', 'A natural juice of sweet oranges', 2.50, NOW(), 2)");

            mb.Sql("INSERT INTO Products (Name, ImageUrl, Description, Price, ReleaseDate, CategoryId) " +
                   "VALUES ('Chocolate cake', 'chocolatecake.jpg', 'A delicious cake with cocoa', 31.99, NOW(), 3)");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");
        }
    }
}
