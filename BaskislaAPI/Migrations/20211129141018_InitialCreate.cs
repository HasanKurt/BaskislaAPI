using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaskislaAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "marriages",
                columns: table => new
                {
                    MarriageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    male = table.Column<int>(type: "int", nullable: false),
                    female = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marriages", x => x.MarriageId);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    father = table.Column<int>(type: "int", nullable: true),
                    mother = table.Column<int>(type: "int", nullable: true),
                    is_living = table.Column<bool>(type: "bit", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "marriages");

            migrationBuilder.DropTable(
                name: "persons");
        }
    }
}
