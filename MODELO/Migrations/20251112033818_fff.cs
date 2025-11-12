using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class fff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaServicio_Categorias_CategoriasCategoriaId",
                table: "CategoriaServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoriaServicio_Servicios_ServiciosServicioId",
                table: "CategoriaServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriaServicio",
                table: "CategoriaServicio");

            migrationBuilder.RenameTable(
                name: "CategoriaServicio",
                newName: "ServiciosCategorias");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriaServicio_ServiciosServicioId",
                table: "ServiciosCategorias",
                newName: "IX_ServiciosCategorias_ServiciosServicioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiciosCategorias",
                table: "ServiciosCategorias",
                columns: new[] { "CategoriasCategoriaId", "ServiciosServicioId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosCategorias_Categorias_CategoriasCategoriaId",
                table: "ServiciosCategorias",
                column: "CategoriasCategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosCategorias_Servicios_ServiciosServicioId",
                table: "ServiciosCategorias",
                column: "ServiciosServicioId",
                principalTable: "Servicios",
                principalColumn: "ServicioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosCategorias_Categorias_CategoriasCategoriaId",
                table: "ServiciosCategorias");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosCategorias_Servicios_ServiciosServicioId",
                table: "ServiciosCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiciosCategorias",
                table: "ServiciosCategorias");

            migrationBuilder.RenameTable(
                name: "ServiciosCategorias",
                newName: "CategoriaServicio");

            migrationBuilder.RenameIndex(
                name: "IX_ServiciosCategorias_ServiciosServicioId",
                table: "CategoriaServicio",
                newName: "IX_CategoriaServicio_ServiciosServicioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriaServicio",
                table: "CategoriaServicio",
                columns: new[] { "CategoriasCategoriaId", "ServiciosServicioId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaServicio_Categorias_CategoriasCategoriaId",
                table: "CategoriaServicio",
                column: "CategoriasCategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriaServicio_Servicios_ServiciosServicioId",
                table: "CategoriaServicio",
                column: "ServiciosServicioId",
                principalTable: "Servicios",
                principalColumn: "ServicioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
