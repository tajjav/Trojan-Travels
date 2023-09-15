using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addingseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Instructor", "Title" },
                values: new object[,]
                {
                    { 1045, 4, "Cheryl Smith", "SQL Server" },
                    { 1050, 3, "John Dean", "Internet Application 2" },
                    { 2021, 3, "Kate Bill", "Internet Application 1" },
                    { 2042, 3, "Fred More", "jQuery" },
                    { 3141, 4, "Alex Byron", "Introduction to C#" },
                    { 4022, 3, "David Doe", "Java" },
                    { 4041, 3, "Juan Kate", "Object Oriented Sofware Development" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EnrollmentDate", "FirstName", "Gender", "ImageFile", "Initials", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andy", 0, "AndyAYoung.jpg", "A", "Young" },
                    { 2, new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", 1, "JaneYHarriman.jpg", "Y", "Harriman" },
                    { 3, new DateTime(1997, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kate", 2, "KateGGeorge.jpg", "G", "George" },
                    { 4, new DateTime(2003, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marc", 0, "MarcHBredd.jpg", "H", "Bredd" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { 1, 1050, 0, 1 },
                    { 2, 4022, 2, 1 },
                    { 3, 4041, 1, 1 },
                    { 4, 1045, 1, 2 },
                    { 5, 3141, 5, 2 },
                    { 6, 2021, 5, 2 },
                    { 7, 1050, null, 3 },
                    { 8, 1050, null, 4 },
                    { 9, 4022, 5, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3141);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4022);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4041);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
