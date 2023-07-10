using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NIPAPI.Data.Migrations
{
    public partial class seededCourseAndRegistration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Rating", "Teacher", "Title" },
                values: new object[,]
                {
                    { 1, "Chemical reaction", 4.5, "Mr Ben", "Chemistry" },
                    { 2, "Physical reaction", 4.2999999999999998, "Mrs Joy", "Physics" },
                    { 3, "Agile methodology", 4.0, "Mr Steve", "Agile" }
                });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "CourseId", "Date", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 10, 15, 41, 39, 302, DateTimeKind.Utc).AddTicks(1795), 1 },
                    { 2, 2, new DateTime(2023, 7, 10, 15, 41, 39, 302, DateTimeKind.Utc).AddTicks(1799), 2 },
                    { 3, 3, new DateTime(2023, 7, 10, 15, 41, 39, 302, DateTimeKind.Utc).AddTicks(1801), 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
