using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class Middle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Course",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Products",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitPrice",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Products",
                newName: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
