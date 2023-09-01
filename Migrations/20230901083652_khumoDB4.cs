using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class khumoDB4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c072d09-54d9-4f35-9381-756f4777e6f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f3882a9-dac0-4f4d-9eef-ba5af2ad1f73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb77758-8f66-493a-8156-ce4426fb28e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bf98e08-7297-4f42-91a9-d1b9301d275c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62bd044a-ebe5-469c-a858-36b2450f2813", "753b1b2d-1ee6-48ae-9e58-debf344c706d", "Patient", "PATIENT" },
                    { "73e81783-f89c-490a-b212-514f279344ea", "0369b30b-12c2-4b7d-89d0-63efc1d57341", "Nurse", "NURSE" },
                    { "87ec3870-6746-41bf-ae1c-d2ad66229763", "8d68b20d-fd53-4660-907e-59ae53d013ee", "Admin", "ADMIN" },
                    { "e49405ee-5951-4339-9882-84d6509f64ac", "350f0f21-d417-4205-adc1-eb7a2281ffe7", "Doctor", "Doctor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62bd044a-ebe5-469c-a858-36b2450f2813");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e81783-f89c-490a-b212-514f279344ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ec3870-6746-41bf-ae1c-d2ad66229763");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e49405ee-5951-4339-9882-84d6509f64ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c072d09-54d9-4f35-9381-756f4777e6f3", "6f5cbf85-2ce2-499c-956f-61d954a98303", "Nurse", "NURSE" },
                    { "4f3882a9-dac0-4f4d-9eef-ba5af2ad1f73", "38cfb0ac-b7b6-4d28-8e88-b7d1f7c913f0", "Patient", "PATIENT" },
                    { "5eb77758-8f66-493a-8156-ce4426fb28e3", "a936d1a1-bdeb-4325-b20b-c19a21ede269", "Admin", "ADMIN" },
                    { "9bf98e08-7297-4f42-91a9-d1b9301d275c", "c2af66c9-d18c-402a-b9a3-cc2b0174fa41", "Doctor", "Doctor" }
                });
        }
    }
}
