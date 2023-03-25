using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Ch_Id", "Ch_Title", "Q_ID" },
                values: new object[,]
                {
                    { 16, "Generic Fresh Bacon", 9167 },
                    { 26, "Practical Fresh Cheese", 9167 },
                    { 14, "Incredible Fresh Pizza", 9167 },
                     { 15, "Incredible", 9167 }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumn: "Ch_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumn: "Ch_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumn: "Ch_Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9116);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9124);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9127);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9151);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9180);

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Ch_Id", "Ch_Title", "Q_ID" },
                values: new object[,]
                {
                    { 170, "Metal", 2 },
                    { 194, "Metal", 2 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Q_Id", "AnsID", "AnsTitle", "CrsID", "Q_Mark", "QuesTitle", "type" },
                values: new object[,]
                {
                    { 9103, 95, "front end framework", 1, 0, "Ab exercitationem nam enim. Tempore repellendus rerum laborum similique ea corporis. Aut eos mollitia laborum ipsum voluptatem a atque. Et voluptates vero earum. Qui adipisci quia. ?", "MCQ" },
                    { 9114, 95, "front end framework", 1, 0, "Dolorem numquam quia quia aut quis. Eaque repellendus eius neque et mollitia provident quas doloremque ut. Fugiat in dolorem omnis eum rem alias. ?", "MCQ" },
                    { 9126, 95, "front end framework", 1, 0, "Aut numquam et. Rem ipsum odio rerum pariatur. Ut totam consectetur ut aut fugiat nihil autem. Placeat iure impedit omnis ut. Est enim deleniti voluptate quia ut consequatur et aperiam aut. ?", "MCQ" },
                    { 9188, 95, "front end framework", 1, 0, "Temporibus repellat cum. Aut explicabo eligendi. Et sunt eos quaerat eos. Facilis quod consequatur ut beatae et non sint quis dignissimos. Atque commodi reprehenderit sed voluptatem doloribus. Occaecati provident in architecto officia cupiditate fugiat debitis ullam. ?", "MCQ" },
                    { 9189, 95, "front end framework", 1, 0, "Sapiente voluptatem accusamus provident corrupti aut quaerat voluptas cumque. Eum quo est aliquam libero dolore necessitatibus accusantium amet possimus. Sed laborum quo excepturi a. ?", "MCQ" }
                });
        }
    }
}
