using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDaMulher.Migrations
{
    /// <inheritdoc />
    public partial class Motivos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Razoes_RazaoId",
                table: "Consultas");

            migrationBuilder.DropTable(
                name: "Razoes");

            migrationBuilder.CreateTable(
                name: "Motivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motivos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Motivos_RazaoId",
                table: "Consultas",
                column: "RazaoId",
                principalTable: "Motivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Motivos_RazaoId",
                table: "Consultas");

            migrationBuilder.DropTable(
                name: "Motivos");

            migrationBuilder.CreateTable(
                name: "Razoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razoes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Razoes_RazaoId",
                table: "Consultas",
                column: "RazaoId",
                principalTable: "Razoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
