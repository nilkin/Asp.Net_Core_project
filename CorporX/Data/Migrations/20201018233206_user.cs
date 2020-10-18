using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Data.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Lastname", "Name", "Password", "Token" },
                values: new object[] { 9999, "admin@mail.com", "admin", "admin", "AQAAAAEAACcQAAAAEPFBEHcudvFHnRPhntVlXk/nwgnxHAf+c1oVJaoJNwOt3cNdDQPKjKX4dI+aN8BNUA==", "AQAAAAEAACcQAAAAEIQkMwpUcTMKwdYPY9ujciKM3zzYaDi7SAuE4niZpMamCQyZnFySZ7Dsly7s3xw93w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9999);
        }
    }
}
