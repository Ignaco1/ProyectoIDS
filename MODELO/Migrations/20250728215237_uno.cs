using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class uno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaMotivoCancelacion_MotivoCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "ReservaMotivoCancelacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotivoCancelacion",
                table: "MotivoCancelacion");

            migrationBuilder.RenameTable(
                name: "MotivoCancelacion",
                newName: "MotivosCancelacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotivosCancelacion",
                table: "MotivosCancelacion",
                column: "MotivoCancelacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaMotivoCancelacion_MotivosCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "ReservaMotivoCancelacion",
                column: "MotivosCancelacionMotivoCancelacionId",
                principalTable: "MotivosCancelacion",
                principalColumn: "MotivoCancelacionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaMotivoCancelacion_MotivosCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "ReservaMotivoCancelacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotivosCancelacion",
                table: "MotivosCancelacion");

            migrationBuilder.RenameTable(
                name: "MotivosCancelacion",
                newName: "MotivoCancelacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotivoCancelacion",
                table: "MotivoCancelacion",
                column: "MotivoCancelacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaMotivoCancelacion_MotivoCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "ReservaMotivoCancelacion",
                column: "MotivosCancelacionMotivoCancelacionId",
                principalTable: "MotivoCancelacion",
                principalColumn: "MotivoCancelacionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
