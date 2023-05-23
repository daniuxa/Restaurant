using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    public partial class InitValuesForMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuPositions",
                columns: new[] { "PositionId", "Name", "PhotoLink", "Price" },
                values: new object[,]
                {
                    { new Guid("177b95a1-8ead-4fb1-8510-9bec5c89c16a"), "Dorado", "https://ik.imagekit.io/Salivon/Menu/177b95a1-8ead-4fb1-8510-9bec5c89c16a?updatedAt=1684828620582", 400m },
                    { new Guid("2a287245-da79-4f6f-9bca-29c4fd1c8b05"), "Grilled fish", "https://ik.imagekit.io/Salivon/Menu/2a287245-da79-4f6f-9bca-29c4fd1c8b05?updatedAt=1684828669643", 500m },
                    { new Guid("349ac30a-ffa1-4c2f-a871-a172100d5dd7"), "Kebab", "https://ik.imagekit.io/Salivon/Menu/349ac30a-ffa1-4c2f-a871-a172100d5dd7?updatedAt=1684828595451", 400m },
                    { new Guid("78506416-6bc4-469e-9b03-1e2cf5b708a3"), "Steak", "https://ik.imagekit.io/Salivon/Menu/78506416-6bc4-469e-9b03-1e2cf5b708a3?updatedAt=1684828867102", 600m },
                    { new Guid("7bdc8f1d-6677-4065-8425-218e4c8bac36"), "Fried with tomato souce", "https://ik.imagekit.io/Salivon/Menu/7bdc8f1d-6677-4065-8425-218e4c8bac36?updatedAt=1684828713325", 700m },
                    { new Guid("a23bcec4-d07c-4e6a-a131-43a064066304"), "Chef summer fish", "https://ik.imagekit.io/Salivon/Menu/a23bcec4-d07c-4e6a-a131-43a064066304?updatedAt=1684828784696", 500m },
                    { new Guid("a680749e-8e43-4877-9fe4-cb7b3caf130d"), "Humburger", "https://ik.imagekit.io/Salivon/Menu/a680749e-8e43-4877-9fe4-cb7b3caf130d?updatedAt=1684828898277", 500m },
                    { new Guid("c5d0bd03-f244-4429-b59c-181268153359"), "Salmon", "https://ik.imagekit.io/Salivon/Menu/c5d0bd03-f244-4429-b59c-181268153359?updatedAt=1684828638160", 600m },
                    { new Guid("d0d023f5-aea2-4b19-9b18-f949b02ea87d"), "Nugets", "https://ik.imagekit.io/Salivon/Menu/d0d023f5-aea2-4b19-9b18-f949b02ea87d?updatedAt=1684828605346", 300m },
                    { new Guid("fa744911-5fc6-486a-9cd4-3a09c539a31e"), "Easter fish", "https://ik.imagekit.io/Salivon/Menu/fa744911-5fc6-486a-9cd4-3a09c539a31e?updatedAt=1684828749243", 650m },
                    { new Guid("47d6710b-32e5-429d-8723-e7971f6bef17"), "Orange juice", "https://ik.imagekit.io/Salivon/Menu/47d6710b-32e5-429d-8723-e7971f6bef17", 130m },
                    { new Guid("ab10d367-35f4-4da6-ab7f-01413eddd8d4"), "Apple juice", "https://ik.imagekit.io/Salivon/Menu/ab10d367-35f4-4da6-ab7f-01413eddd8d4", 130m },
                    { new Guid("b46d3334-e53f-4dfa-bea9-3a1aef72d5d1"), "Black tea", "https://ik.imagekit.io/Salivon/Menu/b46d3334-e53f-4dfa-bea9-3a1aef72d5d1", 100m },
                    { new Guid("cc26f172-64bd-4b14-aeca-2ffe1f7d4d63"), "Latte", "https://ik.imagekit.io/Salivon/Menu/cc26f172-64bd-4b14-aeca-2ffe1f7d4d63", 140m },
                    { new Guid("cdc8e3c4-42c5-47e9-932d-5d196c04351e"), "Espresso", "https://ik.imagekit.io/Salivon/Menu/cdc8e3c4-42c5-47e9-932d-5d196c04351e?updatedAt=1684867378345", 100m },
                    { new Guid("eb80cd9d-6586-4d76-ae91-a8e6bf5c8b5e"), "Cappuccino", "https://ik.imagekit.io/Salivon/Menu/eb80cd9d-6586-4d76-ae91-a8e6bf5c8b5e", 130m },
                    { new Guid("17a90d7e-9726-4d7f-bf96-7ca47080c27c"), "Davide Observador", "https://ik.imagekit.io/Salivon/Menu/17a90d7e-9726-4d7f-bf96-7ca47080c27c?updatedAt=1684863814548", 2500m },
                    { new Guid("2c3279d1-2e2b-40cf-80ab-cc2e0167f809"), "Quinta Bons Ventos", "https://ik.imagekit.io/Salivon/Menu/2c3279d1-2e2b-40cf-80ab-cc2e0167f809?updatedAt=1684863128831", 300m },
                    { new Guid("378aae16-d4f0-4f78-8232-ac7dd40d0687"), "Alentejo Herdade Sobroso Cellar Selection", "https://ik.imagekit.io/Salivon/Menu/378aae16-d4f0-4f78-8232-ac7dd40d0687?updatedAt=1684863364089", 1200m },
                    { new Guid("ace050bf-ecf4-4444-9509-310f996676d3"), "Els Bassotets", "https://ik.imagekit.io/Salivon/Menu/ace050bf-ecf4-4444-9509-310f996676d3?updatedAt=1684863752948", 1100m },
                    { new Guid("b6a6574f-d702-49c3-829d-c00ac75ede7d"), "Quinta Camarate Doce", "https://ik.imagekit.io/Salivon/Menu/b6a6574f-d702-49c3-829d-c00ac75ede7d?updatedAt=1684863224821", 750m },
                    { new Guid("ccec7ad3-2928-4ca9-963e-1d9b705ff1be"), "Valdaya Mirum", "https://ik.imagekit.io/Salivon/Menu/ccec7ad3-2928-4ca9-963e-1d9b705ff1be?updatedAt=1684863955912", 3200m },
                    { new Guid("f2b2b4a2-6930-4d60-bb14-ec740ea92164"), "Vidigueira Syrah", "https://ik.imagekit.io/Salivon/Menu/f2b2b4a2-6930-4d60-bb14-ec740ea92164?updatedAt=1684863172948", 550m }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "PositionId", "TypeOfDish", "Weight" },
                values: new object[,]
                {
                    { new Guid("177b95a1-8ead-4fb1-8510-9bec5c89c16a"), "Fish", 250.0 },
                    { new Guid("2a287245-da79-4f6f-9bca-29c4fd1c8b05"), "Fish", 250.0 },
                    { new Guid("349ac30a-ffa1-4c2f-a871-a172100d5dd7"), "Meat", 350.0 },
                    { new Guid("78506416-6bc4-469e-9b03-1e2cf5b708a3"), "Meat", 500.0 },
                    { new Guid("7bdc8f1d-6677-4065-8425-218e4c8bac36"), "Fish", 250.0 },
                    { new Guid("a23bcec4-d07c-4e6a-a131-43a064066304"), "Fish", 250.0 },
                    { new Guid("a680749e-8e43-4877-9fe4-cb7b3caf130d"), "Burger", 400.0 },
                    { new Guid("c5d0bd03-f244-4429-b59c-181268153359"), "Fish", 250.0 },
                    { new Guid("d0d023f5-aea2-4b19-9b18-f949b02ea87d"), "Meat", 250.0 },
                    { new Guid("fa744911-5fc6-486a-9cd4-3a09c539a31e"), "Fish", 250.0 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "PositionId", "TypeOfDrink", "Volume" },
                values: new object[,]
                {
                    { new Guid("47d6710b-32e5-429d-8723-e7971f6bef17"), "Juice", 200.0 },
                    { new Guid("ab10d367-35f4-4da6-ab7f-01413eddd8d4"), "Juice", 200.0 },
                    { new Guid("b46d3334-e53f-4dfa-bea9-3a1aef72d5d1"), "Tea", 150.0 },
                    { new Guid("cc26f172-64bd-4b14-aeca-2ffe1f7d4d63"), "Coffe", 50.0 },
                    { new Guid("cdc8e3c4-42c5-47e9-932d-5d196c04351e"), "Coffe", 30.0 },
                    { new Guid("eb80cd9d-6586-4d76-ae91-a8e6bf5c8b5e"), "Coffe", 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Wines",
                columns: new[] { "PositionId", "Brand", "Country", "IsBottle", "RegionName", "TypeOfWine", "Year" },
                values: new object[,]
                {
                    { new Guid("17a90d7e-9726-4d7f-bf96-7ca47080c27c"), "Observador", "Spain", true, "Rías Baixas", "White", 2022 },
                    { new Guid("2c3279d1-2e2b-40cf-80ab-cc2e0167f809"), "Ventos", "Portugal", true, "Lisboa", "Red", 2015 },
                    { new Guid("378aae16-d4f0-4f78-8232-ac7dd40d0687"), "Alentejo Herdade", "Portugal", true, "Alentejo", "White", 2016 },
                    { new Guid("ace050bf-ecf4-4444-9509-310f996676d3"), "Bassotets", "Spain", true, "Conca de Barberà", "White", 2022 },
                    { new Guid("b6a6574f-d702-49c3-829d-c00ac75ede7d"), "Doce", "Portugal", true, "Setúbal", "White", 2019 },
                    { new Guid("ccec7ad3-2928-4ca9-963e-1d9b705ff1be"), "Mirum", "Spain", true, "Ribera del Duero", "White", 2019 },
                    { new Guid("f2b2b4a2-6930-4d60-bb14-ec740ea92164"), "Syrah", "Portugal", true, "Alentejo", "Red", 2012 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("177b95a1-8ead-4fb1-8510-9bec5c89c16a"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("2a287245-da79-4f6f-9bca-29c4fd1c8b05"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("349ac30a-ffa1-4c2f-a871-a172100d5dd7"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("78506416-6bc4-469e-9b03-1e2cf5b708a3"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("7bdc8f1d-6677-4065-8425-218e4c8bac36"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("a23bcec4-d07c-4e6a-a131-43a064066304"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("a680749e-8e43-4877-9fe4-cb7b3caf130d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("c5d0bd03-f244-4429-b59c-181268153359"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("d0d023f5-aea2-4b19-9b18-f949b02ea87d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "PositionId",
                keyValue: new Guid("fa744911-5fc6-486a-9cd4-3a09c539a31e"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("47d6710b-32e5-429d-8723-e7971f6bef17"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("ab10d367-35f4-4da6-ab7f-01413eddd8d4"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("b46d3334-e53f-4dfa-bea9-3a1aef72d5d1"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("cc26f172-64bd-4b14-aeca-2ffe1f7d4d63"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("cdc8e3c4-42c5-47e9-932d-5d196c04351e"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "PositionId",
                keyValue: new Guid("eb80cd9d-6586-4d76-ae91-a8e6bf5c8b5e"));

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "PositionId",
                keyValue: new Guid("17a90d7e-9726-4d7f-bf96-7ca47080c27c"));

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "PositionId",
                keyValue: new Guid("2c3279d1-2e2b-40cf-80ab-cc2e0167f809"));

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "PositionId",
                keyValue: new Guid("378aae16-d4f0-4f78-8232-ac7dd40d0687"));

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "PositionId",
                keyValue: new Guid("ace050bf-ecf4-4444-9509-310f996676d3"));

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "PositionId",
                keyValue: new Guid("b6a6574f-d702-49c3-829d-c00ac75ede7d"));

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "PositionId",
                keyValue: new Guid("ccec7ad3-2928-4ca9-963e-1d9b705ff1be"));

            migrationBuilder.DeleteData(
                table: "Wines",
                keyColumn: "PositionId",
                keyValue: new Guid("f2b2b4a2-6930-4d60-bb14-ec740ea92164"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("177b95a1-8ead-4fb1-8510-9bec5c89c16a"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("2a287245-da79-4f6f-9bca-29c4fd1c8b05"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("349ac30a-ffa1-4c2f-a871-a172100d5dd7"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("78506416-6bc4-469e-9b03-1e2cf5b708a3"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("7bdc8f1d-6677-4065-8425-218e4c8bac36"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("a23bcec4-d07c-4e6a-a131-43a064066304"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("a680749e-8e43-4877-9fe4-cb7b3caf130d"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("c5d0bd03-f244-4429-b59c-181268153359"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("d0d023f5-aea2-4b19-9b18-f949b02ea87d"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("fa744911-5fc6-486a-9cd4-3a09c539a31e"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("47d6710b-32e5-429d-8723-e7971f6bef17"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("ab10d367-35f4-4da6-ab7f-01413eddd8d4"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("b46d3334-e53f-4dfa-bea9-3a1aef72d5d1"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("cc26f172-64bd-4b14-aeca-2ffe1f7d4d63"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("cdc8e3c4-42c5-47e9-932d-5d196c04351e"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("eb80cd9d-6586-4d76-ae91-a8e6bf5c8b5e"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("17a90d7e-9726-4d7f-bf96-7ca47080c27c"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("2c3279d1-2e2b-40cf-80ab-cc2e0167f809"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("378aae16-d4f0-4f78-8232-ac7dd40d0687"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("ace050bf-ecf4-4444-9509-310f996676d3"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("b6a6574f-d702-49c3-829d-c00ac75ede7d"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("ccec7ad3-2928-4ca9-963e-1d9b705ff1be"));

            migrationBuilder.DeleteData(
                table: "MenuPositions",
                keyColumn: "PositionId",
                keyValue: new Guid("f2b2b4a2-6930-4d60-bb14-ec740ea92164"));
        }
    }
}
