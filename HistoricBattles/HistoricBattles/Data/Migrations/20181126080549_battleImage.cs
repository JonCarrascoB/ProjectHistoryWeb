using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricBattles.Data.Migrations
{
    public partial class battleImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Battles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Battles");
        }
    }
}
