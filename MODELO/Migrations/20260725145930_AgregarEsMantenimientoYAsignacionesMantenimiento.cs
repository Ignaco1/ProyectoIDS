using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEsMantenimientoYAsignacionesMantenimiento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EsMantenimiento",
                table: "RolesEmpleados",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "AsignacionesMantenimiento",
                columns: table => new
                {
                    AsignacionMantenimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MantenimientoId = table.Column<int>(type: "int", nullable: false),
                    CabañaId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionesMantenimiento", x => x.AsignacionMantenimientoId);
                    table.ForeignKey(
                        name: "FK_AsignacionesMantenimiento_Cabañas_CabañaId",
                        column: x => x.CabañaId,
                        principalTable: "Cabañas",
                        principalColumn: "CabañaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignacionesMantenimiento_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignacionesMantenimiento_Mantenimientos_MantenimientoId",
                        column: x => x.MantenimientoId,
                        principalTable: "Mantenimientos",
                        principalColumn: "MantenimientoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesMantenimiento_CabañaId",
                table: "AsignacionesMantenimiento",
                column: "CabañaId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesMantenimiento_EmpleadoId",
                table: "AsignacionesMantenimiento",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionesMantenimiento_MantenimientoId",
                table: "AsignacionesMantenimiento",
                column: "MantenimientoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignacionesMantenimiento");

            migrationBuilder.DropColumn(
                name: "EsMantenimiento",
                table: "RolesEmpleados");
        }
    }
}
