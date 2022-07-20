using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wordle.DAL.Migrations
{
    public partial class Base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CurrentDate",
                table: "Games",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CurrentWordId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WordId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Term = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_WordId",
                table: "Games",
                column: "WordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Words_WordId",
                table: "Games",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Words_WordId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Games_WordId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CurrentDate",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CurrentWordId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "WordId",
                table: "Games");
        }
    }
}
