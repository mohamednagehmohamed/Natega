using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Natega.Shared.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stage_New_Dawly",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seating_no = table.Column<int>(type: "int", nullable: false),
                    arabic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    s1 = table.Column<int>(type: "int", nullable: false),
                    s10 = table.Column<int>(type: "int", nullable: false),
                    s14 = table.Column<int>(type: "int", nullable: false),
                    student_case = table.Column<int>(type: "int", nullable: false),
                    student_case_desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage_New_Dawly", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stage_New_Search",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seating_no = table.Column<int>(type: "int", nullable: false),
                    arabic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    total_degree = table.Column<float>(type: "real", nullable: false),
                    student_case = table.Column<int>(type: "int", nullable: false),
                    student_case_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_flage = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage_New_Search", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_Search",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_Search", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stage_New_Dawly");

            migrationBuilder.DropTable(
                name: "Stage_New_Search");

            migrationBuilder.DropTable(
                name: "X_Search");
        }
    }
}
