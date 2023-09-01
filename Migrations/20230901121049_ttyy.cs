using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class ttyy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "07d9edd8-b5b2-4973-b43f-7f7adefdc4c5", "458d2933-3bcb-430e-978b-04192fc48540", "Doctor", "Doctor" },
                    { "09c76ba4-968b-4b61-9b61-a12ef236e521", "edff9f5a-36fb-4688-9db1-6b02a0115550", "Nurse", "NURSE" },
                    { "1a536232-9767-4d99-abbe-a36fbedfa485", "7bda52bf-5a13-4518-bcb8-3211eed7c543", "Patient", "PATIENT" },
                    { "6b277ff6-63c2-4bf5-8b01-156bbd9bc08a", "429f7dc5-0ec7-46e4-9ff1-051c941779f8", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07d9edd8-b5b2-4973-b43f-7f7adefdc4c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09c76ba4-968b-4b61-9b61-a12ef236e521");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a536232-9767-4d99-abbe-a36fbedfa485");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b277ff6-63c2-4bf5-8b01-156bbd9bc08a");

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
    }
}
