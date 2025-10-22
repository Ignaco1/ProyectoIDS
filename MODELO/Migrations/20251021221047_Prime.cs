using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class Prime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    MovimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMovimiento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.MovimientoId);
                });

            migrationBuilder.CreateTable(
                name: "ClientesAuditoria",
                columns: table => new
                {
                    ClienteAuditoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaMovimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesAuditoria", x => x.ClienteAuditoriaId);
                    table.ForeignKey(
                        name: "FK_ClientesAuditoria_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesAuditoria_Movimientos_MovimientoId",
                        column: x => x.MovimientoId,
                        principalTable: "Movimientos",
                        principalColumn: "MovimientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesAuditoria_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosAuditoria",
                columns: table => new
                {
                    UsuarioAuditoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaLogout = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MovimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosAuditoria", x => x.UsuarioAuditoriaId);
                    table.ForeignKey(
                        name: "FK_UsuariosAuditoria_Movimientos_MovimientoId",
                        column: x => x.MovimientoId,
                        principalTable: "Movimientos",
                        principalColumn: "MovimientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosAuditoria_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientesAuditoria_IdCliente",
                table: "ClientesAuditoria",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesAuditoria_IdUsuario",
                table: "ClientesAuditoria",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesAuditoria_MovimientoId",
                table: "ClientesAuditoria",
                column: "MovimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosAuditoria_IdUsuario",
                table: "UsuariosAuditoria",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosAuditoria_MovimientoId",
                table: "UsuariosAuditoria",
                column: "MovimientoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesAuditoria");

            migrationBuilder.DropTable(
                name: "UsuariosAuditoria");

            migrationBuilder.DropTable(
                name: "Movimientos");
        }
    }
}
