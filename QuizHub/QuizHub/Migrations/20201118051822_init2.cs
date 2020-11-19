using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizHub.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "qq_question",
                table: "quiz_Questions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "qq_question",
                table: "quiz_Questions");
        }
    }
}
