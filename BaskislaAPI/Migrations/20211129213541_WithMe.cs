using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaskislaAPI.Migrations
{
    public partial class WithMe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "first_name", "gender", "is_living", "last_name", "father", "mother" },
                values: new object[] { 1, "Hasan", "M", true, "Kurt", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
