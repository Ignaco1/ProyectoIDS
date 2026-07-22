using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCancelacionAsignacionServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cancelada",
                table: "AsignacionesServicio",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "AsignacionServicioMotivoCancelacion",
                columns: table => new
                {
                    AsignacionesServicioAsignacionServicioId = table.Column<int>(type: "int", nullable: false),
                    MotivosCancelacionMotivoCancelacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionServicioMotivoCancelacion", x => new { x.AsignacionesServicioAsignacionServicioId, x.MotivosCancelacionMotivoCancelacionId });
                    table.ForeignKey(
                        name: "FK_AsignacionServicioMotivoCancelacion_AsignacionesServicio_AsignacionesServicioAsignacionServicioId",
                        column: x => x.AsignacionesServicioAsignacionServicioId,
                        principalTable: "AsignacionesServicio",
                        principalColumn: "AsignacionServicioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionServicioMotivoCancelacion_MotivosCancelacion_MotivosCancelacionMotivoCancelacionId",
                        column: x => x.MotivosCancelacionMotivoCancelacionId,
                        principalTable: "MotivosCancelacion",
                        principalColumn: "MotivoCancelacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionServicioMotivoCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "AsignacionServicioMotivoCancelacion",
                column: "MotivosCancelacionMotivoCancelacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignacionServicioMotivoCancelacion");

            migrationBuilder.DropColumn(
                name: "Cancelada",
                table: "AsignacionesServicio");
        }
    }
}
