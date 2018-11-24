using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricBattles.Data.Migrations
{
    public partial class regimchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Regiments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Regiments");
        }
    }
}
