using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizHub.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "quiz_Categories",
                columns: table => new
                {
                    qc_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qc_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quiz_Categories", x => x.qc_Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    u_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.u_id);
                });

            migrationBuilder.CreateTable(
                name: "quiz_Questions",
                columns: table => new
                {
                    qq_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qq_opta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qq_optb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qq_optc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qq_optd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qq_ans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qc_Id = table.Column<int>(type: "int", nullable: false),
                    quiz_catqc_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quiz_Questions", x => x.qq_id);
                    table.ForeignKey(
                        name: "FK_quiz_Questions_quiz_Categories_quiz_catqc_Id",
                        column: x => x.quiz_catqc_Id,
                        principalTable: "quiz_Categories",
                        principalColumn: "qc_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_Progresses",
                columns: table => new
                {
                    up_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rans = table.Column<int>(type: "int", nullable: false),
                    wans = table.Column<int>(type: "int", nullable: false),
                    u_id = table.Column<int>(type: "int", nullable: false),
                    useru_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_Progresses", x => x.up_id);
                    table.ForeignKey(
                        name: "FK_user_Progresses_users_useru_id",
                        column: x => x.useru_id,
                        principalTable: "users",
                        principalColumn: "u_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_quiz_Questions_quiz_catqc_Id",
                table: "quiz_Questions",
                column: "quiz_catqc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_user_Progresses_useru_id",
                table: "user_Progresses",
                column: "useru_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quiz_Questions");

            migrationBuilder.DropTable(
                name: "user_Progresses");

            migrationBuilder.DropTable(
                name: "quiz_Categories");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
