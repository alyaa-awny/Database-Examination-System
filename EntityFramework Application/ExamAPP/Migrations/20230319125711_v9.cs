using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Ch_Id", "Ch_Title", "Q_ID" },
                values: new object[,] { 
                    { 5, "Metal", 9107 },
                    { 6, "exercitationem", 9107 },
                    { 7, "sunt", 9107 },
                    { 8, "voluptatem", 9107 }

                });

          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Choices",
                keyColumn: "Ch_Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9103);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9114);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9126);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9188);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9189);

            migrationBuilder.UpdateData(
                table: "Choices",
                keyColumn: "Ch_Id",
                keyValue: 194,
                column: "Ch_Title",
                value: "Steel");

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Ch_Id", "Ch_Title", "Q_ID" },
                values: new object[,]
                {
                    { 152, "Frozen", 2 },
                    { 167, "Fresh", 2 },
                    { 184, "Wooden", 2 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Q_Id", "AnsID", "AnsTitle", "CrsID", "Q_Mark", "QuesTitle", "type" },
                values: new object[,]
                {
                    { 9108, 95, "front end framework", 1, 0, "Iste corporis dicta eligendi et consequatur voluptatum veritatis. Consequuntur dolore vel quisquam saepe nobis. Aut doloremque vel molestiae magni rem velit quia omnis quam. Vero rerum et natus labore minus ut alias. ?", "MCQ" },
                    { 9109, 95, "front end framework", 1, 0, "Velit vel aut et quia qui rerum. Qui illo dolore rerum. Deleniti debitis et est placeat modi. Dicta ut labore iste eum dicta aut aut. Sed nam debitis enim. ?", "MCQ" },
                    { 9127, 95, "front end framework", 1, 0, "Qui ea iusto nulla. Commodi labore assumenda sed iusto ratione consequatur eos eligendi aut. Quos libero laborum voluptates quia omnis consequatur. Quaerat maxime blanditiis aut. ?", "MCQ" },
                    { 9150, 95, "front end framework", 1, 0, "Nam autem tempora ut esse quibusdam ratione voluptates occaecati. Et et asperiores quod natus tempore cum sit. Reprehenderit excepturi voluptatem quidem dolores autem. ?", "MCQ" },
                    { 9165, 95, "front end framework", 1, 0, "Doloribus quasi cum aliquam autem. Rerum quisquam eveniet quas et repellat corrupti. Quam quidem quidem. Ratione rerum ipsum vero deserunt et laborum enim vel qui. ?", "MCQ" },
                    { 9175, 95, "front end framework", 1, 0, "Voluptate non eos et voluptatem quisquam corrupti. Maxime amet ut quis. Ducimus nihil vel architecto. ?", "MCQ" },
                    { 9182, 95, "front end framework", 1, 0, "Eius rerum nihil nemo. Velit itaque maxime ut vero sit reprehenderit eaque ut. Id labore aut quo ipsum. Fuga quo culpa qui facere distinctio non reprehenderit consequatur. Necessitatibus odio molestiae reprehenderit. Modi incidunt est. ?", "MCQ" }
                });
        }
    }
}
