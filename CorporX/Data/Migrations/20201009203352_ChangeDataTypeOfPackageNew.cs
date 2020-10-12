using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Data.Migrations
{
    public partial class ChangeDataTypeOfPackageNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderBy",
                table: "Packages");

            migrationBuilder.AddColumn<string>(
                name: "BtnClass",
                table: "Packages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Packages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BtnClass",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Packages");

            migrationBuilder.AddColumn<int>(
                name: "OrderBy",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
