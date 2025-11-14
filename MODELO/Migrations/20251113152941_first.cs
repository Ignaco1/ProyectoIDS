using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImagenesServicio",
                columns: table => new
                {
                    ImagenServicioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenesServicio", x => x.ImagenServicioId);
                    table.ForeignKey(
                        name: "FK_ImagenesServicio_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "ServicioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagenesServicio_ServicioId",
                table: "ImagenesServicio",
                column: "ServicioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenesServicio");
        }
    }
}
