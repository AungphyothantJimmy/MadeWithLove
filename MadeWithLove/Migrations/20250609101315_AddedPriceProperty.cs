using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MadeWithLove.Migrations
{
    /// <inheritdoc />
    public partial class AddedPriceProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductPrice",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "Products");
        }
    }
}
