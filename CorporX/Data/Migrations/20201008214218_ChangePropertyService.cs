using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Data.Migrations
{
    public partial class ChangePropertyService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPromoThird",
                table: "Services",
                newName: "IsPromoServ");

            migrationBuilder.RenameColumn(
                name: "IsPromoSecond",
                table: "Services",
                newName: "IsPromoAbout");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPromoServ",
                table: "Services",
                newName: "IsPromoThird");

            migrationBuilder.RenameColumn(
                name: "IsPromoAbout",
                table: "Services",
                newName: "IsPromoSecond");
        }
    }
}
