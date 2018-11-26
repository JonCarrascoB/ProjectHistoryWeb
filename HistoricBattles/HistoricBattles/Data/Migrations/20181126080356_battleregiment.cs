using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricBattles.Data.Migrations
{
    public partial class battleregiment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Regiments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regiments_BattleId",
                table: "Regiments",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regiments_Battles_BattleId",
                table: "Regiments",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiments_Battles_BattleId",
                table: "Regiments");

            migrationBuilder.DropIndex(
                name: "IX_Regiments_BattleId",
                table: "Regiments");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Regiments");
        }
    }
}
