using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuilderBuddy.Migrations
{
    public partial class UpdateWithTestInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Room_RoomsID",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Project_RoomsID",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "NumberOfWalls",
                table: "Room",
                newName: "NumberofWalls");

            migrationBuilder.RenameColumn(
                name: "InteriorCorners",
                table: "Room",
                newName: "ProjectID");

            migrationBuilder.RenameColumn(
                name: "ExteriorCorners",
                table: "Room",
                newName: "RoomID");

            migrationBuilder.RenameColumn(
                name: "RoomsID",
                table: "Project",
                newName: "NumberOfRooms");

            migrationBuilder.AlterColumn<int>(
                name: "RoomID",
                table: "Room",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<decimal>(
                name: "RoomCost",
                table: "Room",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "Room",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalCost",
                table: "Project",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectDate",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Project",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "RoomID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Room_ProjectID",
                table: "Room",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Wall_RoomID",
                table: "Wall",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Project_ProjectID",
                table: "Room",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Project_ProjectID",
                table: "Room");

            migrationBuilder.DropTable(
                name: "Wall");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_ProjectID",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomCost",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "ProjectDate",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "NumberofWalls",
                table: "Room",
                newName: "NumberOfWalls");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "Room",
                newName: "InteriorCorners");

            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "Room",
                newName: "ExteriorCorners");

            migrationBuilder.RenameColumn(
                name: "NumberOfRooms",
                table: "Project",
                newName: "RoomsID");

            migrationBuilder.AlterColumn<int>(
                name: "ExteriorCorners",
                table: "Room",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Room",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalCost",
                table: "Project",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_RoomsID",
                table: "Project",
                column: "RoomsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Room_RoomsID",
                table: "Project",
                column: "RoomsID",
                principalTable: "Room",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
