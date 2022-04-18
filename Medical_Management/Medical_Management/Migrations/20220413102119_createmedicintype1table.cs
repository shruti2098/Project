using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical_Management.Migrations
{
    public partial class createmedicintype1table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicineTypeId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customer_Id",
                table: "Billings",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MedicineType_MedicineTypeId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MedicineTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MedicineTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Customer_Id",
                table: "Billings");
        }
    }
}
