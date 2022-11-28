using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoNotas.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Disciplinas_IdDisciplina",
                table: "Notas");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Disciplinas_IdDisciplina",
                table: "Notas",
                column: "IdDisciplina",
                principalTable: "Disciplinas",
                principalColumn: "IdDiciplina");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Disciplinas_IdDisciplina",
                table: "Notas");

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Disciplinas_IdDisciplina",
                table: "Notas",
                column: "IdDisciplina",
                principalTable: "Disciplinas",
                principalColumn: "IdDiciplina");
        }
    }
}
