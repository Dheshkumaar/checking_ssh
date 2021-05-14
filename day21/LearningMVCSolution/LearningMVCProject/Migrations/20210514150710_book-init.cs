using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningMVCProject.Migrations
{
    public partial class bookinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Author_id", "Price", "Title" },
                values: new object[] { 1, null, 1, 120f, "x-men" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
