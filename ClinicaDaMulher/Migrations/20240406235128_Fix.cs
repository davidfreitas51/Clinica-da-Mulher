using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDaMulher.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Motivos_RazaoId",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "RazaoId",
                table: "Consultas",
                newName: "MotivoId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_RazaoId",
                table: "Consultas",
                newName: "IX_Consultas_MotivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Motivos_MotivoId",
                table: "Consultas",
                column: "MotivoId",
                principalTable: "Motivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Motivos_MotivoId",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "MotivoId",
                table: "Consultas",
                newName: "RazaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_MotivoId",
                table: "Consultas",
                newName: "IX_Consultas_RazaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Motivos_RazaoId",
                table: "Consultas",
                column: "RazaoId",
                principalTable: "Motivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
