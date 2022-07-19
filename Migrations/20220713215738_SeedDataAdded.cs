using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectID", "ProjectDate", "ProjectName", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 7, 13, 17, 57, 38, 79, DateTimeKind.Local).AddTicks(3133), "Lincoln's Cabin", null });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomID", "ProjectID", "RoomCost", "RoomName" },
                values: new object[] { 1, 1, null, "Main Room" });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "RoomID", "WallCost" },
                values: new object[] { 1, 8, 24, 1, null });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "RoomID", "WallCost" },
                values: new object[] { 2, 8, 16, 1, null });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "RoomID", "WallCost" },
                values: new object[] { 3, 8, 24, 1, null });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "RoomID", "WallCost" },
                values: new object[] { 4, 8, 16, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1);
        }
    }
}
