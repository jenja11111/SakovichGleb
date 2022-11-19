using Microsoft.EntityFrameworkCore.Migrations;

namespace SakovichGleb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Semestrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NSemestr = table.Column<byte>(type: "tinyint", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semestrs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Semestrs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSemestr = table.Column<int>(type: "int", nullable: false),
                    SemestrId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Months_Semestrs_SemestrId",
                        column: x => x.SemestrId,
                        principalTable: "Semestrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NHourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMonth = table.Column<int>(type: "int", nullable: false),
                    Lectures = table.Column<int>(type: "int", nullable: false),
                    PracticesLessons = table.Column<int>(type: "int", nullable: false),
                    Labs = table.Column<int>(type: "int", nullable: false),
                    KursWork = table.Column<int>(type: "int", nullable: false),
                    RGR = table.Column<int>(type: "int", nullable: false),
                    TestWork = table.Column<int>(type: "int", nullable: false),
                    Offsets = table.Column<int>(type: "int", nullable: false),
                    Consaltings = table.Column<int>(type: "int", nullable: false),
                    Exams = table.Column<float>(type: "real", nullable: false),
                    Practics = table.Column<int>(type: "int", nullable: false),
                    GuidanceDiplomaDesign = table.Column<int>(type: "int", nullable: false),
                    ConsaltingDiplomaDesign = table.Column<int>(type: "int", nullable: false),
                    ReviewDiplomaDesign = table.Column<int>(type: "int", nullable: false),
                    GEK = table.Column<float>(type: "real", nullable: false),
                    Mag = table.Column<int>(type: "int", nullable: false),
                    GuidancePost = table.Column<int>(type: "int", nullable: false),
                    Noil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllTime = table.Column<float>(type: "real", nullable: false),
                    MonthId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NHourses_Months_MonthId",
                        column: x => x.MonthId,
                        principalTable: "Months",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Months_SemestrId",
                table: "Months",
                column: "SemestrId");

            migrationBuilder.CreateIndex(
                name: "IX_NHourses_MonthId",
                table: "NHourses",
                column: "MonthId");

            migrationBuilder.CreateIndex(
                name: "IX_Semestrs_UserId",
                table: "Semestrs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NHourses");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "Semestrs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
