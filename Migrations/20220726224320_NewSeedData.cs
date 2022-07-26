using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class NewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 26, 18, 43, 20, 379, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectID", "BoxesOfScrews", "DrywallCost", "DrywallSheets", "JointCompoundCost", "JointTapeCost", "PoundsOfJointCompound", "ProjectDate", "ProjectName", "RollsOfTape", "ScrewsCost", "TotalCost" },
                values: new object[] { 2, 0m, 0m, 0m, 0m, 0m, 0m, new DateTime(2022, 7, 26, 18, 43, 20, 379, DateTimeKind.Local).AddTicks(6492), "John Doe Dining Room Reno", 0m, 0m, 0m });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Area", "Drywall", "DrywallCost", "Height", "JointCompound", "JointCompoundCost", "JointTape", "JointTapeCost", "Length", "ProjectID", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 5, 180m, 7, 105m, 10, 10, 5.0m, 0.2464m, 1.2320m, 18, 2, 198, 6m, 117.2320m });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Area", "Drywall", "DrywallCost", "Height", "JointCompound", "JointCompoundCost", "JointTape", "JointTapeCost", "Length", "ProjectID", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 6, 120m, 4, 60m, 10, 7, 3.5m, 0.1408m, 0.7040m, 12, 2, 132, 4m, 68.2040m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Wall",
                keyColumn: "WallID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1,
                column: "ProjectDate",
                value: new DateTime(2022, 7, 26, 18, 30, 13, 593, DateTimeKind.Local).AddTicks(2863));
        }
    }
}
