using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "ID", "Address", "Age", "DOB", "DeptId", "DeptName", "FName", "LName" },
                values: new object[] { 1, "37 sixth street", 25, new DateTime(2023, 3, 19, 23, 23, 50, 449, DateTimeKind.Local).AddTicks(8257), 1, null, "Mahmoud", "ALyaa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Ch_Id", "Ch_Title", "Q_ID" },
                values: new object[,]
                {
                    { 4, "Generic Fresh Bacon", 9167 },
                    { 6, "Practical Fresh Cheese", 9167 },
                    { 14, "Incredible Fresh Pizza", 9167 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Q_Id", "AnsID", "AnsTitle", "CrsID", "Q_Mark", "QuesTitle", "type" },
                values: new object[,]
                {
                    { 360, 0, "front end framework", 1, 100, "why are we studying this ?", "MCQ" },
                    { 9116, 95, "front end framework", 1, 0, "Sequi id sit aut rerum quisquam a. Ad sit cum laudantium aliquid nostrum veritatis. Omnis et sed quis nostrum. Nisi sit omnis ea officia. Dolorem cumque debitis voluptatem. ?", "MCQ" },
                    { 9124, 95, "front end framework", 1, 0, "Occaecati est doloribus ratione ex. Sit fuga commodi. Ipsa hic non ea suscipit vero qui magnam error pariatur. ?", "MCQ" },
                    { 9127, 95, "front end framework", 1, 0, "Voluptate error harum iste. Repudiandae accusantium est in saepe. Alias nisi ut sint dolores assumenda. Consectetur aut eaque. Dolor maxime ut. ?", "MCQ" },
                    { 9151, 95, "front end framework", 1, 0, "Omnis quasi pariatur nemo iusto officia. Sit impedit id eum nulla. Inventore debitis commodi. ?", "MCQ" },
                    { 9180, 95, "front end framework", 1, 0, "Qui porro minus voluptates. Enim rem a sapiente quod aut. Magnam omnis consectetur culpa debitis facere magnam labore. Tempore aut adipisci modi cum earum. Sunt iste itaque eveniet illum alias maxime architecto. Ut rerum aspernatur molestiae. ?", "MCQ" }
                });
        }
    }
}
