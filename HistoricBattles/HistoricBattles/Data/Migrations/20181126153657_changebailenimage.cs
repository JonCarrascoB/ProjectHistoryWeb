using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricBattles.Data.Migrations
{
    public partial class changebailenimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiments_Battles_BattleId",
                table: "Regiments");

            migrationBuilder.AlterColumn<int>(
                name: "BattleId",
                table: "Regiments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Regiments_Battles_BattleId",
                table: "Regiments",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiments_Battles_BattleId",
                table: "Regiments");

            migrationBuilder.AlterColumn<int>(
                name: "BattleId",
                table: "Regiments",
                nullable: true,
                oldClrType: typeof(int));

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
