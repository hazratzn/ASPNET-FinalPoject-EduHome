using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class UpdateSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Setting");

            migrationBuilder.AddColumn<string>(
                name: "FooterLogo",
                table: "Setting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeaderLogo",
                table: "Setting",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterLogo",
                table: "Setting");

            migrationBuilder.DropColumn(
                name: "HeaderLogo",
                table: "Setting");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Setting",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
