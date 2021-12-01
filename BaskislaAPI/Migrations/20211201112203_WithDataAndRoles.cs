using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaskislaAPI.Migrations
{
    public partial class WithDataAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7197feb0-05a3-4a99-a10b-9afd4ec06acc", "e184361c-edc0-4f49-b934-9c3e8b4e9657", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9c0cab9-0109-4d2f-8d24-594e9f0ff74b", "b833f2eb-6346-44d0-a706-f19061866a2e", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7197feb0-05a3-4a99-a10b-9afd4ec06acc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9c0cab9-0109-4d2f-8d24-594e9f0ff74b");
        }
    }
}
