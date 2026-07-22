using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class RelacionarAsignacionServicioConMotivoPropio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionesServicio_MotivosCancelacionServicio_MotivoCancelacionServicioId",
                table: "AsignacionesServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionServicioMotivoCancelacion_MotivosCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "AsignacionServicioMotivoCancelacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_MotivosCancelacionServicio_MotivoCancelacionServicioId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_MotivoCancelacionServicioId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionesServicio_MotivoCancelacionServicioId",
                table: "AsignacionesServicio");

            migrationBuilder.DropColumn(
                name: "MotivoCancelacionServicioId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "MotivoCancelacionServicioId",
                table: "AsignacionesServicio");

            migrationBuilder.RenameColumn(
                name: "MotivosCancelacionMotivoCancelacionId",
                table: "AsignacionServicioMotivoCancelacion",
                newName: "MotivosCancelacionMotivoCancelacionServicioId");

            migrationBuilder.RenameIndex(
                name: "IX_AsignacionServicioMotivoCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "AsignacionServicioMotivoCancelacion",
                newName: "IX_AsignacionServicioMotivoCancelacion_MotivosCancelacionMotivoCancelacionServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionServicioMotivoCancelacion_MotivosCancelacionServicio_MotivosCancelacionMotivoCancelacionServicioId",
                table: "AsignacionServicioMotivoCancelacion",
                column: "MotivosCancelacionMotivoCancelacionServicioId",
                principalTable: "MotivosCancelacionServicio",
                principalColumn: "MotivoCancelacionServicioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionServicioMotivoCancelacion_MotivosCancelacionServicio_MotivosCancelacionMotivoCancelacionServicioId",
                table: "AsignacionServicioMotivoCancelacion");

            migrationBuilder.RenameColumn(
                name: "MotivosCancelacionMotivoCancelacionServicioId",
                table: "AsignacionServicioMotivoCancelacion",
                newName: "MotivosCancelacionMotivoCancelacionId");

            migrationBuilder.RenameIndex(
                name: "IX_AsignacionServicioMotivoCancelacion_MotivosCancelacionMotivoCancelacionServicioId",
                table: "AsignacionServicioMotivoCancelacion",
                newName: "IX_AsignacionServicioMotivoCancelacion_MotivosCancelacionMotivoCancelacionId");

            migrationBuilder.AddColumn<int>(
                name: "MotivoCancelacionServicioId",
                table: "Reservas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotivoCancelacionServicioId",
                table: "AsignacionesServicio",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_MotivoCancelacionServicioId",
                table: "Reservas",
                column: "MotivoCancelacionServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesServicio_MotivoCancelacionServicioId",
                table: "AsignacionesServicio",
                column: "MotivoCancelacionServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionesServicio_MotivosCancelacionServicio_MotivoCancelacionServicioId",
                table: "AsignacionesServicio",
                column: "MotivoCancelacionServicioId",
                principalTable: "MotivosCancelacionServicio",
                principalColumn: "MotivoCancelacionServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionServicioMotivoCancelacion_MotivosCancelacion_MotivosCancelacionMotivoCancelacionId",
                table: "AsignacionServicioMotivoCancelacion",
                column: "MotivosCancelacionMotivoCancelacionId",
                principalTable: "MotivosCancelacion",
                principalColumn: "MotivoCancelacionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_MotivosCancelacionServicio_MotivoCancelacionServicioId",
                table: "Reservas",
                column: "MotivoCancelacionServicioId",
                principalTable: "MotivosCancelacionServicio",
                principalColumn: "MotivoCancelacionServicioId");
        }
    }
}
