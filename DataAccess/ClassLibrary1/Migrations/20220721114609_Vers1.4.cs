using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wordle.DAL.Migrations
{
    public partial class Vers14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stats_PlayerId",
                table: "Stats",
                column: "PlayerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Stats_PlayerId",
                table: "Stats");
        }
    }
}
