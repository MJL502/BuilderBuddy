using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class InitialCreate : Migration
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
                name: "Room",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomName = table.Column<string>(type: "TEXT", nullable: true),
                    ProjectID = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomCost = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Room_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wall",
                columns: table => new
                {
                    WallID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomID = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    WallCost = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wall", x => x.WallID);
                    table.ForeignKey(
                        name: "FK_Wall_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Materials_WallID",
                table: "Materials",
                column: "WallID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_ProjectID",
                table: "Room",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Wall_RoomID",
                table: "Wall",
                column: "RoomID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Wall");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
