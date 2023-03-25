using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 2, "nextJS" },
                    { 3, ".NET" }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ALyaa" },
                    { 2, "Mona" }
                });

            migrationBuilder.InsertData(
                table: "stud_Crs",
                columns: new[] { "Course_Id", "Student_Id", "Grade" },
                values: new object[,]
                {
                    { 1, 1, 100 },
                    { 1, 2, 75 }
                });

            migrationBuilder.InsertData(
                table: "ins_Courses",
                columns: new[] { "Course_Id", "Instructor_Id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ins_Courses",
                keyColumns: new[] { "Course_Id", "Instructor_Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ins_Courses",
                keyColumns: new[] { "Course_Id", "Instructor_Id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "stud_Crs",
                keyColumns: new[] { "Course_Id", "Student_Id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "stud_Crs",
                keyColumns: new[] { "Course_Id", "Student_Id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "ID", "Address", "Age", "DOB", "DeptId", "DeptName", "FName", "LName" },
                values: new object[] { 21, null, 0, new DateTime(2023, 3, 19, 23, 33, 3, 85, DateTimeKind.Local).AddTicks(7732), 1, "Dept_1", "Ivy", "Beatty" });
        }
    }
}
