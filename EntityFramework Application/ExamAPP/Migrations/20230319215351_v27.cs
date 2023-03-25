using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v27 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "ins_Courses",
                columns: new[] { "Course_Id", "Instructor_Id" },
                values: new object[,]
                {
                    { 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ins_Courses",
                keyColumns: new[] { "Course_Id", "Instructor_Id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ins_Courses",
                keyColumns: new[] { "Course_Id", "Instructor_Id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "ins_Courses",
                columns: new[] { "Course_Id", "Instructor_Id" },
                values: new object[] { 2, 2 });
        }
    }
}
