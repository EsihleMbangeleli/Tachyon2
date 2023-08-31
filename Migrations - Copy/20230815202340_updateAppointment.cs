using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tachyon.Migrations
{
    public partial class updateAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47f8e7ce-bac2-4ba1-87b0-d04778a12656");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e5af500-44fb-42af-9c59-a13fd6757697");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa54db9b-500c-437f-bb1b-1ace81a9942b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdfd7959-7ea9-4d2a-af49-41fd4eb844ba");

            migrationBuilder.RenameColumn(
                name: "DoctorName",
                table: "familyAppointments",
                newName: "NurseName");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "manageFiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "familyAppointments",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "subsystem",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "datetimevalue",
                table: "Booking",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "NurseName",
                table: "familyAppointments",
                newName: "DoctorName");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "manageFiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "familyAppointments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "subsystem",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "datetimevalue",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(225)",
                maxLength: 225,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(225)",
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47f8e7ce-bac2-4ba1-87b0-d04778a12656", "dc95504c-113c-41fb-a9c5-5a34bfef3325", "Admin", "ADMIN" },
                    { "9e5af500-44fb-42af-9c59-a13fd6757697", "83dd4da5-1c93-4cdb-814c-3b67096f35c2", "Doctor", "Doctor" },
                    { "aa54db9b-500c-437f-bb1b-1ace81a9942b", "e38bd034-4ed3-4af8-bd1c-6d35766bc269", "Patient", "PATIENT" },
                    { "bdfd7959-7ea9-4d2a-af49-41fd4eb844ba", "baf02da3-d4dd-4dce-b3bf-a96e2b9176bb", "Nurse", "NURSE" }
                });
        }
    }
}
