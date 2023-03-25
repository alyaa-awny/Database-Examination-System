using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "topics",
                columns: new[] { "ID", "courseId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Ineritance" },
                    { 2, 1, "Pointers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "topics",
                keyColumns: new[] { "ID", "courseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "topics",
                keyColumns: new[] { "ID", "courseId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
