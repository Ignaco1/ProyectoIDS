using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class Primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosAuditoria_Movimientos_MovimientoId",
                table: "UsuariosAuditoria");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosAuditoria_MovimientoId",
                table: "UsuariosAuditoria");

            migrationBuilder.DropColumn(
                name: "MovimientoId",
                table: "UsuariosAuditoria");

            migrationBuilder.AddColumn<int>(
                name: "IdMovimiento",
                table: "UsuariosAuditoria",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoMovimiento",
                table: "UsuariosAuditoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosAuditoria_IdMovimiento",
                table: "UsuariosAuditoria",
                column: "IdMovimiento");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosAuditoria_Movimientos_IdMovimiento",
                table: "UsuariosAuditoria",
                column: "IdMovimiento",
                principalTable: "Movimientos",
                principalColumn: "MovimientoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosAuditoria_Movimientos_IdMovimiento",
                table: "UsuariosAuditoria");

            migrationBuilder.DropIndex(
                name: "IX_UsuariosAuditoria_IdMovimiento",
                table: "UsuariosAuditoria");

            migrationBuilder.DropColumn(
                name: "IdMovimiento",
                table: "UsuariosAuditoria");

            migrationBuilder.DropColumn(
                name: "TipoMovimiento",
                table: "UsuariosAuditoria");

            migrationBuilder.AddColumn<int>(
                name: "MovimientoId",
                table: "UsuariosAuditoria",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosAuditoria_MovimientoId",
                table: "UsuariosAuditoria",
                column: "MovimientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosAuditoria_Movimientos_MovimientoId",
                table: "UsuariosAuditoria",
                column: "MovimientoId",
                principalTable: "Movimientos",
                principalColumn: "MovimientoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
