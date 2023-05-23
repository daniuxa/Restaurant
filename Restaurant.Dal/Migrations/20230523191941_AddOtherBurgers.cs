using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    public partial class AddOtherBurgers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("a680749e-8e43-4877-9fe4-cb7b3caf130d"),
                column: "Name",
                value: "Hamburger menu 4");

            migrationBuilder.InsertData(
                table: "MenuPositions",
                columns: new[] { "PositionId", "Name", "PhotoLink", "Price" },
                values: new object[,]
                {
                    { new Guid("06e0d7c2-9fbb-4c5e-b1cf-3951bba9316e"), "Hamburger menu 1", "https://ik.imagekit.io/Salivon/Menu/06e0d7c2-9fbb-4c5e-b1cf-3951bba9316e?updatedAt=1684869326662", 400m },
                    { new Guid("860617fd-d341-41d2-a494-d982e8ae1f84"), "Hamburger menu 3", "https://ik.imagekit.io/Salivon/Menu/860617fd-d341-41d2-a494-d982e8ae1f84?updatedAt=1684869385003", 550m },
                    { new Guid("94ba0fbc-76ec-4eac-9b48-5ff5859da457"), "Hamburger menu 2", "https://ik.imagekit.io/Salivon/Menu/94ba0fbc-76ec-4eac-9b48-5ff5859da457?updatedAt=1684869350144", 450m }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "PositionId", "TypeOfDish", "Weight" },
                values: new object[] { new Guid("06e0d7c2-9fbb-4c5e-b1cf-3951bba9316e"), "Burger", 350.0 });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "PositionId", "TypeOfDish", "Weight" },
                values: new object[] { new Guid("860617fd-d341-41d2-a494-d982e8ae1f84"), "Burger", 450.0 });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "PositionId", "TypeOfDish", "Weight" },
                values: new object[] { new Guid("94ba0fbc-76ec-4eac-9b48-5ff5859da457"), "Burger", 400.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("06e0d7c2-9fbb-4c5e-b1cf-3951bba9316e"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("860617fd-d341-41d2-a494-d982e8ae1f84"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("94ba0fbc-76ec-4eac-9b48-5ff5859da457"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("06e0d7c2-9fbb-4c5e-b1cf-3951bba9316e"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("860617fd-d341-41d2-a494-d982e8ae1f84"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("94ba0fbc-76ec-4eac-9b48-5ff5859da457"));

            migrationBuilder.UpdateData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("a680749e-8e43-4877-9fe4-cb7b3caf130d"),
                column: "Name",
                value: "Humburger");
        }
    }
}
