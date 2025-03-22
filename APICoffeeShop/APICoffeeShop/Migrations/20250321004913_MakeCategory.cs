using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class MakeCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categories(Name,ImageUrl) Values('Coffee','coffee.jpg')");
            mb.Sql("Insert into Categories(Name,ImageUrl) Values('Juice','juice.jpg')");
            mb.Sql("Insert into Categories(Name,ImageUrl) Values('Cake','cake.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");
        }
    }
}
