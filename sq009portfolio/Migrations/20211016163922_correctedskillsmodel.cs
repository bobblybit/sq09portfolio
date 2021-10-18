using Microsoft.EntityFrameworkCore.Migrations;

namespace portfolio.Migrations
{
    public partial class correctedskillsmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearsOfProficiency",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "Proficiency",
                table: "Skills",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Projects",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "LinkToLivedemo",
                table: "Projects",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proficiency",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "LinkToLivedemo",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "YearsOfProficiency",
                table: "Skills",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Projects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
