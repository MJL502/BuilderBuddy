using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class July24Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 24, 11, 15, 16, 161, DateTimeKind.Local).AddTicks(6893));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Project");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 23, 18, 45, 27, 331, DateTimeKind.Local).AddTicks(4078));
        }
    }
}
