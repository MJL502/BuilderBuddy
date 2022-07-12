using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class JulyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberofWalls",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "NumberOfRooms",
                table: "Project");

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WallID = table.Column<int>(type: "INTEGER", nullable: false),
                    Drywall = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointCompound = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointTape = table.Column<decimal>(type: "TEXT", nullable: false),
                    Screws = table.Column<decimal>(type: "TEXT", nullable: false),
                    DrywallCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointCompoundCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    JointTapeCost = table.Column<decimal>(type: "TEXT", nullable: false),
                    ScrewsCost = table.Column<decimal>(type: "TEXT", nullable: false)
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
                values: new object[] { 1, new DateTime(2022, 7, 12, 17, 41, 26, 671, DateTimeKind.Local).AddTicks(2029), "Lincoln's Cabin", null });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_WallID",
                table: "Materials",
                column: "WallID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectID",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "NumberofWalls",
                table: "Room",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRooms",
                table: "Project",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
