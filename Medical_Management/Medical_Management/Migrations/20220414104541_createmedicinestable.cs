using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical_Management.Migrations
{
    public partial class createmedicinestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "MedicineType");

            migrationBuilder.DropColumn(
                name: "Stock_Id",
                table: "MedicineType");

            migrationBuilder.RenameColumn(
                name: "StockType",
                table: "MedicineType",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Category_Name",
                table: "MedicineType",
                newName: "CreatedBy");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MedicineType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "MedicineType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "MedicineType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MedicineType");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "MedicineType");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "MedicineType");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "MedicineType",
                newName: "StockType");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "MedicineType",
                newName: "Category_Name");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "MedicineType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stock_Id",
                table: "MedicineType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
