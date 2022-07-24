using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class WallUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "JointCompound",
                table: "Wall",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 23, 18, 29, 59, 131, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 1,
                column: "JointCompound",
                value: 11m);

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 2,
                column: "JointCompound",
                value: 7m);

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 3,
                column: "JointCompound",
                value: 11m);

            migrationBuilder.UpdateData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 4,
                column: "JointCompound",
                value: 7m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JointCompound",
                table: "Wall");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 23, 15, 40, 35, 686, DateTimeKind.Local).AddTicks(6643));
        }
    }
}
