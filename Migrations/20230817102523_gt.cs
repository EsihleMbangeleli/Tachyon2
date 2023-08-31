using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class gt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1070cba3-326d-43ae-b481-a5d38abd94aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ebdc544-6e9b-4d97-a126-f2b2c29501da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b6cf080-ff52-4a58-ab73-d1c0e20a4f3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4d2139f-b333-4ccc-9c07-703fde56598d");

            migrationBuilder.CreateTable(
                name: "familyScrenning",
                columns: table => new
                {
                    screnningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Child = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    intercourse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_familyScrenning", x => x.screnningID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "familyScrenning");

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
                    { "1070cba3-326d-43ae-b481-a5d38abd94aa", "9f8e4a19-6207-405e-b441-bdab419ea8c9", "Doctor", "Doctor" },
                    { "3ebdc544-6e9b-4d97-a126-f2b2c29501da", "44647bd0-5c94-4e9c-b449-97fa05cc1121", "Nurse", "NURSE" },
                    { "7b6cf080-ff52-4a58-ab73-d1c0e20a4f3b", "f92b906c-ffd2-45ee-8bec-a557b94adf73", "Admin", "ADMIN" },
                    { "f4d2139f-b333-4ccc-9c07-703fde56598d", "184d8e09-49ba-4d0f-a986-5c91b469e0d1", "Patient", "PATIENT" }
                });
        }
    }
}
