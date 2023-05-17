using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    public partial class ChangedAddressIndeliveryOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "DeliveryOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "DeliveryOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
