using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class KhumoDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1efaa553-72c7-40a9-b0f1-364590c9d62e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c725617-c3a4-4e04-ae51-f15da1cecddd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a261de1f-554c-4454-8930-b124ef70c3a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8f941ee-d8f8-40d8-ab2d-ecd55ccc80fd");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "1efaa553-72c7-40a9-b0f1-364590c9d62e", "75f2b807-5e04-4ae7-ad79-d7c9983336fb", "Admin", "ADMIN" },
                    { "8c725617-c3a4-4e04-ae51-f15da1cecddd", "599fe4d7-ba5f-423c-a3c8-cb987e04fe9f", "Patient", "PATIENT" },
                    { "a261de1f-554c-4454-8930-b124ef70c3a0", "a66f13e4-3ca7-4f4e-bcf3-8e9c7761aeb2", "Doctor", "Doctor" },
                    { "b8f941ee-d8f8-40d8-ab2d-ecd55ccc80fd", "fe754fa2-3851-41b2-a3f9-e5eb31aca680", "Nurse", "NURSE" }
                });
        }
    }
}
