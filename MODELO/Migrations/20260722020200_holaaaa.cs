using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class holaaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "MotivosCancelacionServicio",
                columns: table => new
                {
                    MotivoCancelacionServicioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosCancelacionServicio", x => x.MotivoCancelacionServicioId);
                });

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
                name: "FK_Reservas_MotivosCancelacionServicio_MotivoCancelacionServicioId",
                table: "Reservas",
                column: "MotivoCancelacionServicioId",
                principalTable: "MotivosCancelacionServicio",
                principalColumn: "MotivoCancelacionServicioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionesServicio_MotivosCancelacionServicio_MotivoCancelacionServicioId",
                table: "AsignacionesServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_MotivosCancelacionServicio_MotivoCancelacionServicioId",
                table: "Reservas");

            migrationBuilder.DropTable(
                name: "MotivosCancelacionServicio");

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
        }
    }
}
