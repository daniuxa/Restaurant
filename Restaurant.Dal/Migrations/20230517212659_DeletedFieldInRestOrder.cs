using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    public partial class DeletedFieldInRestOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountOfGuests",
                table: "InRestaurantOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountOfGuests",
                table: "InRestaurantOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
