using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class supreme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MotivoCancelacion",
                columns: table => new
                {
                    MotivoCancelacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoCancelacion", x => x.MotivoCancelacionId);
                });

            migrationBuilder.CreateTable(
                name: "ReservaMotivoCancelacion",
                columns: table => new
                {
                    MotivosCancelacionMotivoCancelacionId = table.Column<int>(type: "int", nullable: false),
                    ReservasReservaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaMotivoCancelacion", x => new { x.MotivosCancelacionMotivoCancelacionId, x.ReservasReservaId });
                    table.ForeignKey(
                        name: "FK_ReservaMotivoCancelacion_MotivoCancelacion_MotivosCancelacionMotivoCancelacionId",
                        column: x => x.MotivosCancelacionMotivoCancelacionId,
                        principalTable: "MotivoCancelacion",
                        principalColumn: "MotivoCancelacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaMotivoCancelacion_Reservas_ReservasReservaId",
                        column: x => x.ReservasReservaId,
                        principalTable: "Reservas",
                        principalColumn: "ReservaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservaMotivoCancelacion_ReservasReservaId",
                table: "ReservaMotivoCancelacion",
                column: "ReservasReservaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservaMotivoCancelacion");

            migrationBuilder.DropTable(
                name: "MotivoCancelacion");
        }
    }
}
