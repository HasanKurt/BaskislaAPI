using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaskislaAPI.Migrations
{
    public partial class WithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "first_name", "last_name", "father", "mother" },
                values: new object[] { "John", "Johnson", 2, 3 });

            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "first_name", "gender", "is_living", "last_name", "father", "mother" },
                values: new object[,]
                {
                    { 2, "Robin", "M", true, "De Jong", 8, 9 },
                    { 3, "Jonathan", "F", true, "Rutte", 26, 27 },
                    { 5, "Mary", "F", true, "Ilyasoglu", 13, 14 },
                    { 6, "Jones", "M", true, "achternam", 2, 3 },
                    { 7, "Tim", "M", true, "soyad", 2, 3 },
                    { 8, "Thomas", "M", false, "lastname", 85, 86 },
                    { 9, "John", "F", false, "Johnson", 94, 87 },
                    { 10, "Robin", "M", true, "De Jong", 8, 9 },
                    { 11, "Jonathan", "F", true, "Rutte", 8, 9 },
                    { 12, "Mary", "F", true, "Ilyasoglu", 8, 9 },
                    { 13, "Jones", "M", true, "achternam", 22, 23 },
                    { 14, "Tim", "F", true, "soyad", 18, 19 },
                    { 15, "Thomas", "F", true, "lastname", 13, 14 },
                    { 16, "John", "F", true, "Johnson", 13, 14 },
                    { 17, "Robin", "F", true, "De Jong", 13, 14 },
                    { 18, "Jonathan", "M", true, "Rutte", 95, 98 },
                    { 19, "Mary", "F", true, "Ilyasoglu", 93, 92 },
                    { 20, "Jones", "M", true, "achternam", 18, 19 },
                    { 21, "Tim", "M", true, "soyad", 18, 19 },
                    { 22, "Thomas", "M", true, "lastname", 186, 188 },
                    { 23, "John", "F", true, "Johnson", null, null },
                    { 24, "Robin", "F", true, "De Jong", 22, 23 },
                    { 25, "Jonathan", "F", true, "Rutte", 22, 78 },
                    { 26, "Mary", "M", false, "Ilyasoglu", 88, 89 },
                    { 27, "Jones", "F", true, "achternam", 90, 91 },
                    { 28, "Tim", "F", true, "soyad", 26, 27 },
                    { 29, "Thomas", "F", true, "lastname", 26, 27 },
                    { 30, "John", "M", true, "Johnson", 26, 27 },
                    { 31, "Robin", "F", true, "De Jong", 26, 27 },
                    { 32, "Jonathan", "F", true, "Rutte", 81, 11 },
                    { 33, "Mary", "F", true, "Ilyasoglu", 81, 11 },
                    { 34, "Jones", "F", true, "achternam", 81, 11 },
                    { 35, "Tim", "M", true, "soyad", 10, 54 },
                    { 36, "Thomas", "F", true, "lastname", 10, 54 },
                    { 37, "John", "M", true, "Johnson", 53, 12 },
                    { 38, "Robin", "F", true, "De Jong", 53, 12 },
                    { 39, "Jonathan", "F", true, "Rutte", 53, 12 },
                    { 40, "Mary", "M", true, "Ilyasoglu", 55, 31 },
                    { 41, "Jones", "M", true, "achternam", 55, 31 },
                    { 42, "Tim", "F", true, "soyad", 55, 31 },
                    { 43, "Thomas", "M", true, "lastname", 30, 56 }
                });

            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "first_name", "gender", "is_living", "last_name", "father", "mother" },
                values: new object[,]
                {
                    { 44, "John", "M", true, "Johnson", 30, 56 },
                    { 45, "Robin", "F", true, "De Jong", 30, 56 },
                    { 46, "Jonathan", "M", true, "Rutte", 57, 28 },
                    { 47, "Mary", "M", true, "Ilyasoglu", 57, 28 },
                    { 48, "Jones", "F", true, "achternam", 57, 28 },
                    { 49, "Tim", "M", true, "soyad", 58, 29 },
                    { 50, "Thomas", "M", true, "lastname", 58, 29 },
                    { 51, "John", "M", true, "Johnson", 58, 29 },
                    { 53, "Robin", "M", true, "De Jong", 193, 194 },
                    { 54, "Jonathan", "F", true, "Rutte", null, null },
                    { 56, "Mary", "F", true, "Ilyasoglu", null, null },
                    { 57, "Jones", "M", true, "achternam", null, null },
                    { 58, "Tim", "M", true, "soyad", 116, null },
                    { 59, "Thomas", "M", true, "lastname", null, null },
                    { 60, "John", "F", true, "Johnson", null, null },
                    { 61, "Robin", "F", true, "De Jong", 197, 198 },
                    { 62, "Jonathan", "M", true, "Rutte", 59, 24 },
                    { 63, "Mary", "M", true, "Ilyasoglu", 59, 24 },
                    { 64, "Jones", "F", true, "achternam", 20, 84 },
                    { 65, "Tim", "M", true, "soyad", 21, 61 },
                    { 66, "Thomas", "M", true, "lastname", 21, 61 },
                    { 67, "John", "M", true, "Johnson", null, null },
                    { 68, "Robin", "F", true, "De Jong", 67, 42 },
                    { 69, "Jonathan", "F", true, "Rutte", 67, 42 },
                    { 70, "Mary", "M", false, "Ilyasoglu", 67, 42 },
                    { 71, "Jones", "F", true, "achternam", null, null },
                    { 72, "Tim", "M", true, "soyad", null, null },
                    { 73, "Thomas", "F", true, "lastname", 40, 71 },
                    { 74, "John", "M", true, "Johnson", 75, 32 },
                    { 75, "Robin", "M", true, "De Jong", null, null },
                    { 76, "Jonathan", "F", true, "Rutte", null, null },
                    { 77, "Mary", "F", true, "Ilyasoglu", 62, 83 },
                    { 78, "Jones", "F", true, "achternam", null, null },
                    { 79, "Tim", "M", true, "soyad", 80, 25 },
                    { 80, "Thomas", "M", true, "lastname", null, null },
                    { 81, "John", "M", true, "Johnson", 142, 120 },
                    { 82, "Robin", "M", true, "De Jong", null, null },
                    { 83, "Jonathan", "F", true, "Rutte", null, null },
                    { 84, "Mary", "F", true, "Ilyasoglu", null, null },
                    { 85, "Jones", "M", false, "achternam", 110, null },
                    { 86, "Tim", "F", false, "soyad", null, null },
                    { 87, "Thomas", "F", false, "lastname", null, null }
                });

            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "first_name", "gender", "is_living", "last_name", "father", "mother" },
                values: new object[,]
                {
                    { 88, "John", "M", false, "Johnson", null, null },
                    { 89, "Robin", "F", false, "De Jong", null, null },
                    { 90, "Jonathan", "M", false, "Rutte", 96, 97 },
                    { 91, "Mary", "F", false, "Ilyasoglu", null, null },
                    { 92, "Jones", "F", false, "achternam", null, null },
                    { 93, "Tim", "M", false, "soyad", null, null },
                    { 94, "Thomas", "M", false, "lastname", null, null },
                    { 95, "John", "M", false, "Johnson", null, null },
                    { 96, "Robin", "M", false, "De Jong", null, null },
                    { 97, "Jonathan", "F", false, "Rutte", null, null },
                    { 98, "Mary", "F", false, "Ilyasoglu", null, null },
                    { 99, "Jones", "M", false, "achternam", 85, 86 },
                    { 100, "Tim", "M", false, "soyad", 85, 101 },
                    { 101, "Thomas", "F", false, "lastname", null, null },
                    { 102, "John", "M", true, "Johnson", 93, 92 },
                    { 103, "Robin", "M", true, "De Jong", 93, 92 },
                    { 104, "Jonathan", "M", false, "Rutte", 93, 92 },
                    { 105, "Mary", "F", true, "Ilyasoglu", 102, 109 },
                    { 106, "Jones", "M", true, "achternam", 102, 109 },
                    { 107, "Tim", "M", true, "soyad", 102, 109 },
                    { 108, "Thomas", "M", true, "lastname", 102, 109 },
                    { 109, "John", "F", true, "Johnson", null, null },
                    { 110, "Robin", "M", false, "De Jong", null, null },
                    { 111, "Jonathan", "M", true, "Rutte", 90, 91 },
                    { 112, "Mary", "M", true, "Ilyasoglu", 90, 91 },
                    { 113, "Jones", "F", true, "achternam", 90, 91 },
                    { 114, "Tim", "F", true, "soyad", 90, 91 },
                    { 115, "Thomas", "F", true, "lastname", 90, 91 },
                    { 116, "John", "M", false, "Johnson", null, null },
                    { 117, "Robin", "M", false, "De Jong", null, null },
                    { 118, "Jonathan", "M", true, "Rutte", 117, 150 },
                    { 119, "Mary", "M", true, "Ilyasoglu", 117, 150 },
                    { 120, "Jones", "F", true, "achternam", 117, 150 },
                    { 121, "Tim", "F", true, "soyad", 117, 150 },
                    { 122, "Thomas", "F", true, "lastname", 117, 150 },
                    { 123, "John", "M", true, "Johnson", 119, 141 },
                    { 124, "Robin", "M", true, "De Jong", 119, 141 },
                    { 125, "Jonathan", "M", true, "Rutte", 119, 141 },
                    { 126, "Mary", "F", true, "Ilyasoglu", 118, 140 },
                    { 127, "Jones", "M", true, "achternam", 118, 140 },
                    { 128, "Tim", "F", true, "soyad", 118, 140 },
                    { 129, "Thomas", "M", true, "lastname", 118, 140 }
                });

            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "first_name", "gender", "is_living", "last_name", "father", "mother" },
                values: new object[,]
                {
                    { 130, "John", "M", true, "Johnson", 139, 121 },
                    { 131, "Robin", "F", true, "De Jong", 139, 121 },
                    { 132, "Jonathan", "M", true, "Rutte", 139, 121 },
                    { 133, "Mary", "M", true, "Ilyasoglu", 139, 121 },
                    { 134, "Jones", "F", true, "achternam", 138, 122 },
                    { 135, "Tim", "F", true, "soyad", 138, 122 },
                    { 136, "Thomas", "M", true, "lastname", 138, 122 },
                    { 137, "John", "M", true, "Johnson", 138, 122 },
                    { 138, "Robin", "M", true, "De Jong", null, null },
                    { 139, "Jonathan", "M", true, "Rutte", 99, null },
                    { 140, "Mary", "F", true, "Ilyasoglu", null, null },
                    { 141, "Jones", "F", true, "achternam", null, null },
                    { 142, "Tim", "M", true, "soyad", null, null },
                    { 143, "Thomas", "F", true, "lastname", 117, 150 },
                    { 144, "John", "F", true, "Johnson", 117, 150 },
                    { 145, "Robin", "M", true, "De Jong", null, null },
                    { 146, "Jonathan", "M", true, "Rutte", null, null },
                    { 147, "Mary", "F", true, "Ilyasoglu", 142, 120 },
                    { 148, "Jones", "M", true, "achternam", 142, 120 },
                    { 149, "Tim", "F", true, "soyad", 142, 120 },
                    { 150, "Thomas", "F", false, "lastname", null, null },
                    { 151, "John", "F", true, "Johnson", null, null },
                    { 152, "Robin", "F", true, "De Jong", null, null },
                    { 153, "Jonathan", "F", true, "Rutte", 154, 155 },
                    { 154, "Mary", "M", true, "Ilyasoglu", null, null },
                    { 155, "Jones", "F", true, "achternam", null, null },
                    { 156, "Tim", "F", true, "soyad", 154, 155 },
                    { 157, "Thomas", "F", true, "lastname", 154, 155 },
                    { 158, "John", "M", true, "Johnson", 154, 155 },
                    { 159, "Robin", "M", true, "De Jong", null, null },
                    { 160, "Jonathan", "M", true, "Rutte", null, null },
                    { 161, "Mary", "M", true, "Ilyasoglu", 159, 156 },
                    { 162, "Jones", "M", true, "achternam", 160, 157 },
                    { 163, "Tim", "F", true, "soyad", null, null },
                    { 164, "Thomas", "M", true, "lastname", null, null },
                    { 165, "John", "F", true, "Johnson", null, null },
                    { 166, "Robin", "F", true, "De Jong", null, null },
                    { 167, "Jonathan", "F", true, "Rutte", 203, 204 },
                    { 168, "Mary", "F", true, "Ilyasoglu", null, null },
                    { 169, "Jones", "M", true, "achternam", null, null },
                    { 170, "Tim", "M", true, "soyad", null, null },
                    { 171, "Thomas", "M", true, "lastname", null, null }
                });

            migrationBuilder.InsertData(
                table: "persons",
                columns: new[] { "id", "first_name", "gender", "is_living", "last_name", "father", "mother" },
                values: new object[,]
                {
                    { 172, "John", "M", true, "Johnson", 177, 178 },
                    { 173, "Robin", "M", true, "De Jong", 177, 178 },
                    { 174, "Jonathan", "F", true, "Rutte", 177, 178 },
                    { 175, "Mary", "F", true, "Ilyasoglu", 177, 178 },
                    { 176, "Jones", "F", true, "achternam", 177, 178 },
                    { 177, "Tim", "M", true, "soyad", null, null },
                    { 178, "Thomas", "F", true, "lastname", null, null },
                    { 179, "John", "F", true, "Johnson", 185, 184 },
                    { 180, "Robin", "F", true, "De Jong", 185, 184 },
                    { 181, "Jonathan", "F", true, "Rutte", 185, 184 },
                    { 182, "Mary", "F", true, "Ilyasoglu", 185, 184 },
                    { 183, "Jones", "M", true, "achternam", 185, 184 },
                    { 184, "Tim", "F", false, "soyad", 88, 89 },
                    { 185, "Thomas", "M", false, "lastname", null, null },
                    { 186, "John", "M", false, "Johnson", 187, null },
                    { 187, "Robin", "M", false, "De Jong", null, null },
                    { 188, "Jonathan", "F", false, "Rutte", null, null },
                    { 189, "Mary", "", null, "Ilyasoglu", 95, 98 },
                    { 190, "Jones", "", null, "achternam", 95, 98 },
                    { 191, "Tim", "", null, "soyad", 95, 98 },
                    { 192, "Thomas", "", null, "lastname", 95, 98 },
                    { 193, "John", "M", true, "Johnson", null, null },
                    { 194, "Robin", "F", true, "De Jong", null, null },
                    { 195, "Jonathan", "M", true, "Rutte", 193, 194 },
                    { 196, "Mary", "M", true, "Ilyasoglu", 193, 194 },
                    { 197, "Jones", "M", false, "achternam", null, null },
                    { 198, "Tim", "F", false, "soyad", null, null },
                    { 199, "Thomas", "M", null, "lastname", 197, 198 },
                    { 200, "John", "", null, "Johnson", 197, 198 },
                    { 203, "Robin", "M", null, "De Jong", null, null },
                    { 204, "Jonathan", "F", null, "Rutte", null, null },
                    { 205, "Mary", "M", null, "Ilyasoglu", 203, 204 },
                    { 206, "Jones", "F", null, "achternam", 207, 192 },
                    { 207, "Tim", "M", null, "soyad", null, null },
                    { 208, "Thomas", "", null, "lastname", 207, 192 },
                    { 209, "John", "", null, "Johnson", 207, 192 },
                    { 210, "Robin", "", null, "De Jong", 207, 192 },
                    { 211, "Jonathan", "", null, "Rutte", 212, 206 },
                    { 212, "Mary", "M", null, "Ilyasoglu", null, null },
                    { 213, "Jones", "", null, "achternam", 212, 206 },
                    { 214, "Tim", "", null, "soyad", 212, 206 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "persons",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.UpdateData(
                table: "persons",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "first_name", "last_name", "father", "mother" },
                values: new object[] { "Hasan", "Kurt", null, null });
        }
    }
}
