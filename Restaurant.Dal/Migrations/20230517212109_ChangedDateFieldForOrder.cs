using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    public partial class ChangedDateFieldForOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CloseDateTime",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OpenDateTime",
                table: "Orders",
                newName: "DateOfOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfOrder",
                table: "Orders",
                newName: "OpenDateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseDateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
