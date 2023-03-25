using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamAPP.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Q_Id", "AnsID", "AnsTitle", "CrsID", "Q_Mark", "QuesTitle", "type" },
                values: new object[,]
                {
                    { 9105, 95, "front end framework", 1, 0, "Recusandae qui quasi rerum odit. Unde aut nihil aspernatur corrupti. Voluptatem modi ab corrupti atque est. Maxime rerum sit corporis nisi. ?", "MCQ" },
                    { 9107, 95, "front end framework", 1, 0, "Impedit deserunt ipsam earum. Sit velit ducimus qui officiis omnis. Reiciendis facere vel qui molestiae neque non dolore perferendis earum. Similique excepturi omnis et. Odio laborum accusamus in et commodi tempore ut officiis. ?", "MCQ" },
                    { 9113, 95, "front end framework", 1, 0, "Aut asperiores voluptatem eos rem temporibus eum doloremque perspiciatis eum. Eum illo incidunt impedit quo expedita numquam quia eos est. Atque porro eos veniam. Molestias sunt quia iure ut dolores repellendus consequatur ipsum et. Reprehenderit et et nesciunt. At dignissimos beatae magni. ?", "MCQ" },
                    { 9123, 95, "front end framework", 1, 0, "Excepturi quidem quas et quas odio fuga ducimus at illum. Est dignissimos magni necessitatibus. Eos ut aut velit. ?", "MCQ" },
                    { 9137, 95, "front end framework", 1, 0, "Qui numquam praesentium est ea molestiae. Accusantium illum non exercitationem. Sed praesentium quod. Quo et et laboriosam earum vel nostrum. Voluptatem autem voluptates deleniti est nihil dolores. Qui atque porro dolore optio enim eius. ?", "MCQ" },
                    { 9160, 95, "front end framework", 1, 0, "Voluptatem porro beatae voluptas sequi ut blanditiis autem hic. Et iusto eveniet eos dolorem aliquid illo architecto. Suscipit doloremque est. Aspernatur ullam ratione consequatur eius dignissimos deleniti sapiente sed incidunt. Temporibus voluptatem illo mollitia sed aut nulla quaerat ea aut. Laborum excepturi quisquam placeat quam sint hic error ducimus. ?", "MCQ" },
                    { 9167, 95, "front end framework", 1, 0, "Voluptas dolorem vitae sunt tempora velit est et velit. Id repudiandae dolorum voluptate error autem officia et exercitationem. Quis eligendi nisi aut. Eaque deserunt eaque tempora aperiam mollitia eos numquam. Iure qui eaque quod odit porro animi blanditiis. Dicta culpa similique earum harum in asperiores nobis sit temporibus. ?", "MCQ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9105);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9107);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9113);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9123);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9137);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9160);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Q_Id",
                keyValue: 9167);
        }
    }
}
