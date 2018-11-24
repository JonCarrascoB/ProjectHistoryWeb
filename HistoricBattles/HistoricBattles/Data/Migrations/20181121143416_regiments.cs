using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricBattles.Data.Migrations
{
    public partial class regiments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiments_Battles_BattleId",
                table: "Regiments");

            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "Regiments",
                newName: "StageId");

            migrationBuilder.RenameIndex(
                name: "IX_Regiments_BattleId",
                table: "Regiments",
                newName: "IX_Regiments_StageId");

            migrationBuilder.AddColumn<int>(
                name: "PosX",
                table: "Regiments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PosY",
                table: "Regiments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Regiments_Stages_StageId",
                table: "Regiments",
                column: "StageId",
                principalTable: "Stages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiments_Stages_StageId",
                table: "Regiments");

            migrationBuilder.DropColumn(
                name: "PosX",
                table: "Regiments");

            migrationBuilder.DropColumn(
                name: "PosY",
                table: "Regiments");

            migrationBuilder.RenameColumn(
                name: "StageId",
                table: "Regiments",
                newName: "BattleId");

            migrationBuilder.RenameIndex(
                name: "IX_Regiments_StageId",
                table: "Regiments",
                newName: "IX_Regiments_BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regiments_Battles_BattleId",
                table: "Regiments",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
