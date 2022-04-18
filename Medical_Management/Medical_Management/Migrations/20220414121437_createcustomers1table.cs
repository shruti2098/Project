using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical_Management.Migrations
{
    public partial class createcustomers1table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Expiry_Date",
                table: "MedicineType",
                newName: "ExpiryDate");

            migrationBuilder.RenameColumn(
                name: "Company",
                table: "MedicineType",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "Customer_Name",
                table: "Customers",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Billings",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Billing_Id",
                table: "Billings",
                newName: "BillingId");

            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "MedicineType",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "Billings",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "MedicineType",
                newName: "Company");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "MedicineType",
                newName: "Expiry_Date");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Customers",
                newName: "Customer_Name");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "Customer_Id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Billings",
                newName: "Customer_Id");

            migrationBuilder.RenameColumn(
                name: "BillingId",
                table: "Billings",
                newName: "Billing_Id");

            migrationBuilder.AlterColumn<int>(
                name: "UnitPrice",
                table: "MedicineType",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "UnitPrice",
                table: "Billings",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
