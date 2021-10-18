using Microsoft.EntityFrameworkCore.Migrations;

namespace portfolio.Migrations
{
    public partial class updatemodelproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FaceBook",
                table: "Contact",
                newName: "SocialMedia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialMedia",
                table: "Contact",
                newName: "FaceBook");
        }
    }
}
