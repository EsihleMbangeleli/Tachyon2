using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class the : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1835bb07-0afd-46c8-9124-44da6e111975");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb169ac8-3bff-4d64-8a09-98c4692523f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8ddcc04-a53d-47b3-8d86-d7714aaedee5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2d060e5-b606-4433-9ba7-bec075214dd3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bd5b05a-8ead-4d66-b1b0-8a0e76930008", "99386f01-761b-4bae-a2b8-7fdd114b44df", "Doctor", "Doctor" },
                    { "59f04f4a-a20b-4ec3-a57f-339798c470d6", "43d9fae3-27a4-4f75-a7a3-5d21fefc3583", "Admin", "ADMIN" },
                    { "9c2c69b3-bd17-4e24-b685-6f86aad7cb37", "80df6f36-6136-4aee-ab1e-e97f4073b748", "Nurse", "NURSE" },
                    { "f34f57dc-bd7f-4dd8-91eb-81d641a05e2b", "9b022a77-6019-4e5d-91d5-35d0a240ed0a", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bd5b05a-8ead-4d66-b1b0-8a0e76930008");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59f04f4a-a20b-4ec3-a57f-339798c470d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c2c69b3-bd17-4e24-b685-6f86aad7cb37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f34f57dc-bd7f-4dd8-91eb-81d641a05e2b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1835bb07-0afd-46c8-9124-44da6e111975", "01712cc1-f327-46ca-aa0a-5c4b0b5bdef7", "Doctor", "Doctor" },
                    { "bb169ac8-3bff-4d64-8a09-98c4692523f1", "c86d2078-e6c7-4451-80e4-18fbdff2ca49", "Admin", "ADMIN" },
                    { "c8ddcc04-a53d-47b3-8d86-d7714aaedee5", "c9a9a706-e8f4-4b4c-bc80-2473279d84d1", "Patient", "PATIENT" },
                    { "e2d060e5-b606-4433-9ba7-bec075214dd3", "808163bb-04d5-41ac-8a0e-d9da6f2ddca4", "Nurse", "NURSE" }
                });
        }
    }
}
