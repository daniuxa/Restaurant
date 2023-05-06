using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    public partial class AddedLinkToPositionInMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoLink",
                table: "Dishes");

            migrationBuilder.AddColumn<string>(
                name: "PhotoLink",
                table: "MenuPositions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoLink",
                table: "MenuPositions");

            migrationBuilder.AddColumn<string>(
                name: "PhotoLink",
                table: "Dishes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
