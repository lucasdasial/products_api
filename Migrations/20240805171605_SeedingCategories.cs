using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace products_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert  into Category(Name, ImageUrl) values('Bebidas', 'bebidas.png')");
            mb.Sql("Insert  into Category(Name, ImageUrl) values('Lanches', 'lanches.png')");
            mb.Sql("Insert  into Category(Name, ImageUrl) values('Sobremesa', 'sobremesa.png')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Category");
        }
    }
}
