using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class NewProjectValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Project");

            migrationBuilder.AddColumn<decimal>(
                name: "BoxesOfScrews",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DrywallCost",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DrywallSheets",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JointCompoundCost",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JointTapeCost",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PoundsOfJointCompound",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RollsOfTape",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ScrewsCost",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 23, 15, 40, 35, 686, DateTimeKind.Local).AddTicks(6643));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoxesOfScrews",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "DrywallCost",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "DrywallSheets",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "JointCompoundCost",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "JointTapeCost",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "PoundsOfJointCompound",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "RollsOfTape",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ScrewsCost",
                table: "Project");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Project",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 21, 9, 30, 51, 574, DateTimeKind.Local).AddTicks(1391));
        }
    }
}
