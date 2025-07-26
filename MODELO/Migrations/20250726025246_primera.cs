using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MODELO.Migrations
{
    /// <inheritdoc />
    public partial class primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Cabañas_CabañaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_CabañaId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "CabañaId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Reservas");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Reservas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdCabaña",
                table: "Reservas",
                column: "IdCabaña");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IdCliente",
                table: "Reservas",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Cabañas_IdCabaña",
                table: "Reservas",
                column: "IdCabaña",
                principalTable: "Cabañas",
                principalColumn: "CabañaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_IdCliente",
                table: "Reservas",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Cabañas_IdCabaña",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_IdCliente",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_IdCabaña",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_IdCliente",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Reservas");

            migrationBuilder.AddColumn<int>(
                name: "CabañaId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CabañaId",
                table: "Reservas",
                column: "CabañaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Cabañas_CabañaId",
                table: "Reservas",
                column: "CabañaId",
                principalTable: "Cabañas",
                principalColumn: "CabañaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
