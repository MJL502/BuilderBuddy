using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class WallUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Area",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Drywall",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DrywallCost",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JointCompoundCost",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JointTape",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JointTapeCost",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Screws",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ScrewsCost",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "WallCost",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 23, 18, 45, 27, 331, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 1,
                columns: new[] { "Area", "Drywall", "DrywallCost", "JointCompoundCost", "JointTape", "JointTapeCost", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 192m, 7m, 105m, 5.5m, 0.2464m, 1.2320m, 212m, 7m, 118.7320m });

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 2,
                columns: new[] { "Area", "Drywall", "DrywallCost", "JointCompoundCost", "JointTape", "JointTapeCost", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 128m, 5m, 75m, 3.5m, 0.176m, 0.880m, 141m, 5m, 84.380m });

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 3,
                columns: new[] { "Area", "Drywall", "DrywallCost", "JointCompoundCost", "JointTape", "JointTapeCost", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 192m, 7m, 105m, 5.5m, 0.2464m, 1.2320m, 212m, 7m, 118.7320m });

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 4,
                columns: new[] { "Area", "Drywall", "DrywallCost", "JointCompoundCost", "JointTape", "JointTapeCost", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 128m, 5m, 75m, 3.5m, 0.176m, 0.880m, 141m, 5m, 84.380m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "Drywall",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "DrywallCost",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "JointCompoundCost",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "JointTape",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "JointTapeCost",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "Screws",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "ScrewsCost",
                table: "Wall");

            migrationBuilder.DropColumn(
                name: "WallCost",
                table: "Wall");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 23, 18, 29, 59, 131, DateTimeKind.Local).AddTicks(5072));
        }
    }
}
