using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class July26Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectName = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DrywallSheets = table.Column<decimal>(type: "TEXT", nullable: false),
                    DrywallCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    PoundsOfJointCompound = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointCompoundCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    RollsOfTape = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointTapeCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    BoxesOfScrews = table.Column<decimal>(type: "TEXT", nullable: false),
                    ScrewsCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    TotalCost = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Wall",
                columns: table => new
                {
                    WallID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectID = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    Area = table.Column<decimal>(type: "TEXT", nullable: false),
                    Drywall = table.Column<int>(type: "INTEGER", nullable: false),
                    JointCompound = table.Column<int>(type: "INTEGER", nullable: false),
                    JointTape = table.Column<decimal>(type: "TEXT", nullable: false),
                    Screws = table.Column<int>(type: "INTEGER", nullable: false),
                    DrywallCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointCompoundCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointTapeCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    ScrewsCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    WallCost = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wall", x => x.WallID);
                    table.ForeignKey(
                        name: "FK_Wall_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectID", "BoxesOfScrews", "DrywallCost", "DrywallSheets", "JointCompoundCost", "JointTapeCost", "PoundsOfJointCompound", "ProjectDate", "ProjectName", "RollsOfTape", "ScrewsCost", "TotalCost" },
                values: new object[] { 1, 0m, 0m, 0m, 0m, 0m, 0m, new DateTime(2022, 7, 26, 18, 30, 13, 593, DateTimeKind.Local).AddTicks(2863), "Lincoln's Cabin", 0m, 0m, 0m });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Area", "Drywall", "DrywallCost", "Height", "JointCompound", "JointCompoundCost", "JointTape", "JointTapeCost", "Length", "ProjectID", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 1, 192m, 7, 105m, 8, 11, 5.5m, 0.2464m, 1.2320m, 24, 1, 212, 7m, 118.7320m });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Area", "Drywall", "DrywallCost", "Height", "JointCompound", "JointCompoundCost", "JointTape", "JointTapeCost", "Length", "ProjectID", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 2, 128m, 4, 60m, 8, 7, 3.5m, 0.1408m, 0.7040m, 16, 1, 141, 5m, 69.2040m });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Area", "Drywall", "DrywallCost", "Height", "JointCompound", "JointCompoundCost", "JointTape", "JointTapeCost", "Length", "ProjectID", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 3, 192m, 7, 105m, 8, 11, 5.5m, 0.2464m, 1.2320m, 24, 1, 212, 7m, 118.7320m });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Area", "Drywall", "DrywallCost", "Height", "JointCompound", "JointCompoundCost", "JointTape", "JointTapeCost", "Length", "ProjectID", "Screws", "ScrewsCost", "WallCost" },
                values: new object[] { 4, 128m, 4, 60m, 8, 7, 3.5m, 0.1408m, 0.7040m, 16, 1, 141, 5m, 69.2040m });

            migrationBuilder.CreateIndex(
                name: "IX_Wall_ProjectID",
                table: "Wall",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wall");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
