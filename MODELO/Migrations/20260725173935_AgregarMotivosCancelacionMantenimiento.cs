using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class AgregarMotivosCancelacionMantenimiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "AsignacionesMantenimiento",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "MotivosCancelacionMantenimiento",
                columns: table => new
                {
                    MotivoCancelacionMantenimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosCancelacionMantenimiento", x => x.MotivoCancelacionMantenimientoId);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionMantenimientoMotivoCancelacion",
                columns: table => new
                {
                    AsignacionesMantenimientoAsignacionMantenimientoId = table.Column<int>(type: "int", nullable: false),
                    MotivosCancelacionMotivoCancelacionMantenimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionMantenimientoMotivoCancelacion", x => new { x.AsignacionesMantenimientoAsignacionMantenimientoId, x.MotivosCancelacionMotivoCancelacionMantenimientoId });
                    table.ForeignKey(
                        name: "FK_AsignacionMantenimientoMotivoCancelacion_AsignacionesMantenimiento_AsignacionesMantenimientoAsignacionMantenimientoId",
                        column: x => x.AsignacionesMantenimientoAsignacionMantenimientoId,
                        principalTable: "AsignacionesMantenimiento",
                        principalColumn: "AsignacionMantenimientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignacionMantenimientoMotivoCancelacion_MotivosCancelacionMantenimiento_MotivosCancelacionMotivoCancelacionMantenimientoId",
                        column: x => x.MotivosCancelacionMotivoCancelacionMantenimientoId,
                        principalTable: "MotivosCancelacionMantenimiento",
                        principalColumn: "MotivoCancelacionMantenimientoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionMantenimientoMotivoCancelacion_MotivosCancelacionMotivoCancelacionMantenimientoId",
                table: "AsignacionMantenimientoMotivoCancelacion",
                column: "MotivosCancelacionMotivoCancelacionMantenimientoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignacionMantenimientoMotivoCancelacion");

            migrationBuilder.DropTable(
                name: "MotivosCancelacionMantenimiento");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "AsignacionesMantenimiento",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
