using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class AplicarStatePatternAAsignacionServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cancelada",
                table: "AsignacionesServicio");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "AsignacionesServicio",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AsignacionesServicio");

            migrationBuilder.AddColumn<bool>(
                name: "Cancelada",
                table: "AsignacionesServicio",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
