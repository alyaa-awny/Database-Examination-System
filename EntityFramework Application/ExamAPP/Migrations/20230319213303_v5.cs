using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "ID", "Address", "Age", "DOB", "DeptId", "DeptName", "FName", "LName" },
                values: new object[] { 21, null, 0, new DateTime(2023, 3, 19, 23, 33, 3, 85, DateTimeKind.Local).AddTicks(7732), 1, "Dept_1", "Ivy", "Beatty" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "ID", "Address", "Age", "DOB", "DeptId", "DeptName", "FName", "LName" },
                values: new object[] { 1, "37 sixth street", 25, new DateTime(2023, 3, 19, 23, 23, 50, 449, DateTimeKind.Local).AddTicks(8257), 1, null, "Mahmoud", "ALyaa" });
        }
    }
}
