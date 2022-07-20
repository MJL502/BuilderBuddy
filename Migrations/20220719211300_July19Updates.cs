using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class July19Updates : Migration
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
                    TotalCost = table.Column<decimal>(type: "TEXT", nullable: true)
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
                    WallCost = table.Column<decimal>(type: "TEXT", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WallID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialID);
                    table.ForeignKey(
                        name: "FK_Materials_Wall_WallID",
                        column: x => x.WallID,
                        principalTable: "Wall",
                        principalColumn: "WallID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectID", "ProjectDate", "ProjectName", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 7, 19, 17, 12, 59, 900, DateTimeKind.Local).AddTicks(8458), "Lincoln's Cabin", null });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "ProjectID", "WallCost" },
                values: new object[] { 1, 8, 24, 1, null });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "ProjectID", "WallCost" },
                values: new object[] { 2, 8, 16, 1, null });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "ProjectID", "WallCost" },
                values: new object[] { 3, 8, 24, 1, null });

            migrationBuilder.InsertData(
                table: "Wall",
                columns: new[] { "WallID", "Height", "Length", "ProjectID", "WallCost" },
                values: new object[] { 4, 8, 16, 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_WallID",
                table: "Materials",
                column: "WallID");

            migrationBuilder.CreateIndex(
                name: "IX_Wall_ProjectID",
                table: "Wall",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Wall");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
