using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    public partial class AddOtherTeas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuPositions",
                columns: new[] { "PositionId", "Name", "PhotoLink", "Price" },
                values: new object[] { new Guid("17a3c19e-1575-4a69-ae89-46059cce8dc7"), "Herbal tea", "https://ik.imagekit.io/Salivon/Menu/17a3c19e-1575-4a69-ae89-46059cce8dc7", 100m });

            migrationBuilder.InsertData(
                table: "MenuPositions",
                columns: new[] { "PositionId", "Name", "PhotoLink", "Price" },
                values: new object[] { new Guid("2708e10a-b0cd-41b9-8ed2-0a8de5d864dd"), "Pineapple juice", "https://ik.imagekit.io/Salivon/Menu/2708e10a-b0cd-41b9-8ed2-0a8de5d864dd", 130m });

            migrationBuilder.InsertData(
                table: "MenuPositions",
                columns: new[] { "PositionId", "Name", "PhotoLink", "Price" },
                values: new object[] { new Guid("ce5db9df-0c47-4bfc-9d5f-1412cf7dc856"), "Green tea", "https://ik.imagekit.io/Salivon/Menu/ce5db9df-0c47-4bfc-9d5f-1412cf7dc856", 150m });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "PositionId", "TypeOfDrink", "Volume" },
                values: new object[] { new Guid("17a3c19e-1575-4a69-ae89-46059cce8dc7"), "Tea", 150.0 });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "PositionId", "TypeOfDrink", "Volume" },
                values: new object[] { new Guid("2708e10a-b0cd-41b9-8ed2-0a8de5d864dd"), "Juice", 200.0 });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "PositionId", "TypeOfDrink", "Volume" },
                values: new object[] { new Guid("ce5db9df-0c47-4bfc-9d5f-1412cf7dc856"), "Tea", 150.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("17a3c19e-1575-4a69-ae89-46059cce8dc7"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("2708e10a-b0cd-41b9-8ed2-0a8de5d864dd"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("ce5db9df-0c47-4bfc-9d5f-1412cf7dc856"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("17a3c19e-1575-4a69-ae89-46059cce8dc7"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("2708e10a-b0cd-41b9-8ed2-0a8de5d864dd"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("ce5db9df-0c47-4bfc-9d5f-1412cf7dc856"));
        }
    }
}
