using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesAuditoria_Movimientos_MovimientoId",
                table: "ClientesAuditoria");

            migrationBuilder.RenameColumn(
                name: "MovimientoId",
                table: "ClientesAuditoria",
                newName: "IdMovimiento");

            migrationBuilder.RenameIndex(
                name: "IX_ClientesAuditoria_MovimientoId",
                table: "ClientesAuditoria",
                newName: "IX_ClientesAuditoria_IdMovimiento");

            migrationBuilder.AddColumn<string>(
                name: "TipoMovimiento",
                table: "ClientesAuditoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesAuditoria_Movimientos_IdMovimiento",
                table: "ClientesAuditoria",
                column: "IdMovimiento",
                principalTable: "Movimientos",
                principalColumn: "MovimientoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesAuditoria_Movimientos_IdMovimiento",
                table: "ClientesAuditoria");

            migrationBuilder.DropColumn(
                name: "TipoMovimiento",
                table: "ClientesAuditoria");

            migrationBuilder.RenameColumn(
                name: "IdMovimiento",
                table: "ClientesAuditoria",
                newName: "MovimientoId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientesAuditoria_IdMovimiento",
                table: "ClientesAuditoria",
                newName: "IX_ClientesAuditoria_MovimientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesAuditoria_Movimientos_MovimientoId",
                table: "ClientesAuditoria",
                column: "MovimientoId",
                principalTable: "Movimientos",
                principalColumn: "MovimientoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
