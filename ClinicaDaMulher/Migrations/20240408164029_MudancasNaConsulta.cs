using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDaMulher.Migrations
{
    /// <inheritdoc />
    public partial class MudancasNaConsulta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Clientes_ClienteId",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_ClienteId",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Consultas");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Consultas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Consultas");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Consultas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_ClienteId",
                table: "Consultas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Clientes_ClienteId",
                table: "Consultas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
