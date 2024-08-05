using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace products_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedingProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert  into Product(Name, ImageUrl, Price, QuantityInStock, CreateAt, CategoryId)" +
                " values('Coca Diet', 'coca.png', 3.99, 10, datetime('now'), 1)");
            mb.Sql("Insert  into Product(Name, ImageUrl, Price, QuantityInStock, CreateAt, CategoryId)" +
                " values('Coxinaha', 'coxinha.png', 4.99, 10, datetime('now'), 2)");
            mb.Sql("Insert  into Product(Name, ImageUrl, Price, QuantityInStock, CreateAt, CategoryId)" +
                " values('Sorvete de morango', 'sorvete.png', '13.99', 10, datetime('now'), 3)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
             mb.Sql("Delete from Product");
        }
    }
}
