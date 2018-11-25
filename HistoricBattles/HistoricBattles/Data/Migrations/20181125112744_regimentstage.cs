using Microsoft.EntityFrameworkCore.Migrations;

namespace HistoricBattles.Data.Migrations
{
    public partial class regimentstage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiments_Stages_StageId",
                table: "Regiments");

            migrationBuilder.RenameColumn(
                name: "StageId",
                table: "Regiments",
                newName: "StageID");

            migrationBuilder.RenameIndex(
                name: "IX_Regiments_StageId",
                table: "Regiments",
                newName: "IX_Regiments_StageID");

            migrationBuilder.AlterColumn<int>(
                name: "StageID",
                table: "Regiments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Regiments_Stages_StageID",
                table: "Regiments",
                column: "StageID",
                principalTable: "Stages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiments_Stages_StageID",
                table: "Regiments");

            migrationBuilder.RenameColumn(
                name: "StageID",
                table: "Regiments",
                newName: "StageId");

            migrationBuilder.RenameIndex(
                name: "IX_Regiments_StageID",
                table: "Regiments",
                newName: "IX_Regiments_StageId");

            migrationBuilder.AlterColumn<int>(
                name: "StageId",
                table: "Regiments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Regiments_Stages_StageId",
                table: "Regiments",
                column: "StageId",
                principalTable: "Stages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
