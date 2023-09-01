using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0a14e5a-77b6-496d-af7c-aeb6a48d64e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b36eb25d-34ba-46e6-909f-04ff0a3f3bbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57dd869-5f27-4ab9-a5ec-b230e283e343");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a3b6a4-bf12-428a-af4c-bb0209fa670e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "401c2466-1b3b-4f5e-b643-815602c4e58c", "619e314f-f2f2-4e00-97ba-7225aea56be7", "Doctor", "Doctor" },
                    { "a51f8f49-cd6b-48b5-be41-d0b7bc102603", "9f79d09c-9a3b-4e99-978b-0d5c903c0848", "Nurse", "NURSE" },
                    { "ddb7b53b-d582-4d5c-bb5f-dddebcc9da9b", "ca3a1f2a-aef0-4eb5-99f9-d46d8c968e3f", "Admin", "ADMIN" },
                    { "f79887ca-2762-45c3-85e5-85a0442a8a21", "0c7cefcd-904b-40cc-965d-ce8756c910dd", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "401c2466-1b3b-4f5e-b643-815602c4e58c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a51f8f49-cd6b-48b5-be41-d0b7bc102603");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddb7b53b-d582-4d5c-bb5f-dddebcc9da9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f79887ca-2762-45c3-85e5-85a0442a8a21");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a0a14e5a-77b6-496d-af7c-aeb6a48d64e2", "07633697-9c8b-464a-b262-3ad860c689b0", "Admin", "ADMIN" },
                    { "b36eb25d-34ba-46e6-909f-04ff0a3f3bbc", "00ee8e89-64c1-4043-a76e-3966e60fe969", "Doctor", "Doctor" },
                    { "d57dd869-5f27-4ab9-a5ec-b230e283e343", "67dfb174-b69d-484f-a9a7-589d8e667676", "Patient", "PATIENT" },
                    { "e0a3b6a4-bf12-428a-af4c-bb0209fa670e", "27fe35dd-d53d-4937-b811-cdf54c222ef8", "Nurse", "NURSE" }
                });
        }
    }
}
