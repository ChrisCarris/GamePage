using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppProject.Migrations
{
    public partial class ReportProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfoModels");

            migrationBuilder.CreateTable(
                name: "ReportProblems",
                columns: table => new
                {
                    ReportProblemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nickname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportProblems", x => x.ReportProblemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportProblems");

            migrationBuilder.CreateTable(
                name: "UserInfoModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountPermissions = table.Column<int>(type: "int", nullable: false),
                    Character_1_Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_1_InGameTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_1_Kingdom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_1_Lvl = table.Column<int>(type: "int", nullable: false),
                    Character_1_Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_1_Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_2_Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_2_InGameTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_2_Kingdom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_2_Lvl = table.Column<int>(type: "int", nullable: false),
                    Character_2_Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_2_Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_3_Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_3_InGameTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_3_Kingdom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_3_Lvl = table.Column<int>(type: "int", nullable: false),
                    Character_3_Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_3_Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_4_Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_4_InGameTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_4_Kingdom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_4_Lvl = table.Column<int>(type: "int", nullable: false),
                    Character_4_Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character_4_Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DebugRequest = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InGameTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoModels", x => x.Id);
                });
        }
    }
}
