using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical_Management.Migrations
{
    public partial class createmedicinetypeetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MedicineType_MedicineTypeId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MedicineTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MedicineTypeId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "MedicineType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category_Name",
                table: "MedicineType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockType",
                table: "MedicineType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock_Id",
                table: "MedicineType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "MedicineType");

            migrationBuilder.DropColumn(
                name: "Category_Name",
                table: "MedicineType");

            migrationBuilder.DropColumn(
                name: "StockType",
                table: "MedicineType");

            migrationBuilder.DropColumn(
                name: "Stock_Id",
                table: "MedicineType");

            migrationBuilder.AddColumn<int>(
                name: "MedicineTypeId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Stock_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Stock_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MedicineTypeId",
                table: "Customers",
                column: "MedicineTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MedicineType_MedicineTypeId",
                table: "Customers",
                column: "MedicineTypeId",
                principalTable: "MedicineType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
