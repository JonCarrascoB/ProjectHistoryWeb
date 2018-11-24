using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricBattles.Data.Migrations
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Stages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Regiments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stages_BattleId",
                table: "Stages",
                column: "BattleId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Stages_Battles_BattleId",
                table: "Stages",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Stages_Battles_BattleId",
                table: "Stages");

            migrationBuilder.DropIndex(
                name: "IX_Stages_BattleId",
                table: "Stages");

            migrationBuilder.DropIndex(
                name: "IX_Regiments_BattleId",
                table: "Regiments");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Regiments");
        }
    }
}
