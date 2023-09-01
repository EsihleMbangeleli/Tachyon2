using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55c38060-f6d0-4480-8b49-c6fbaa118f97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a89ddd8-70c7-40ab-9602-f759f1c8b213");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bd6c5dd-480e-4725-8e89-d1e96a5d9e97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d945a64f-4b7f-4a29-b377-24fb40d5c390");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "149ce0d2-0902-4914-8112-e219078350cf", "66b425a2-bde9-47f5-a6c8-84bbba0f4cae", "Admin", "ADMIN" },
                    { "27f558c3-3a58-4d64-91ca-513adfdab8ff", "093b0cbf-8973-4e6e-806d-27ae0efff852", "Nurse", "NURSE" },
                    { "440eb827-e491-4af6-9b83-ae55e9f2b93f", "87679893-ca9b-4ba8-bf78-214820599983", "Doctor", "Doctor" },
                    { "eba5ef2d-75c3-4c5f-b5e2-6c9a6751a92a", "0eb382c5-2919-45dc-8354-126366923196", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "149ce0d2-0902-4914-8112-e219078350cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27f558c3-3a58-4d64-91ca-513adfdab8ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "440eb827-e491-4af6-9b83-ae55e9f2b93f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eba5ef2d-75c3-4c5f-b5e2-6c9a6751a92a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55c38060-f6d0-4480-8b49-c6fbaa118f97", "abe1aa59-1743-46f7-b4f6-d1801861c83e", "Doctor", "Doctor" },
                    { "9a89ddd8-70c7-40ab-9602-f759f1c8b213", "278a7705-e00e-41e5-a6b0-479332c7953d", "Patient", "PATIENT" },
                    { "9bd6c5dd-480e-4725-8e89-d1e96a5d9e97", "348ed4f7-1cbc-49d8-b135-90ba6551c028", "Admin", "ADMIN" },
                    { "d945a64f-4b7f-4a29-b377-24fb40d5c390", "c861e2f9-5344-4a9d-855f-b519249e76a3", "Nurse", "NURSE" }
                });
        }
    }
}
