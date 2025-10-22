using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesAuditoria_Clientes_IdCliente",
                table: "ClientesAuditoria");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientesAuditoria_Usuarios_IdUsuario",
                table: "ClientesAuditoria");

            migrationBuilder.DropIndex(
                name: "IX_ClientesAuditoria_IdCliente",
                table: "ClientesAuditoria");

            migrationBuilder.DropIndex(
                name: "IX_ClientesAuditoria_IdUsuario",
                table: "ClientesAuditoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ClientesAuditoria_IdCliente",
                table: "ClientesAuditoria",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesAuditoria_IdUsuario",
                table: "ClientesAuditoria",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesAuditoria_Clientes_IdCliente",
                table: "ClientesAuditoria",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesAuditoria_Usuarios_IdUsuario",
                table: "ClientesAuditoria",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
