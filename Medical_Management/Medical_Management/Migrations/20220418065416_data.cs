using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical_Management.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Billings",
                newName: "Quantity");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Billings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Billings");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Billings",
                newName: "CustomerId");
        }
    }
}
