using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wordle.DAL.Migrations
{
    public partial class Updated : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentPlayerId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.DropColumn(
                name: "CurrentPlayerId",
                table: "Games");
        }
    }
}
