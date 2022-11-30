using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoNotas.Migrations
{
    /// <inheritdoc />
    public partial class CriandoBanco1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdNotaDiciplina",
                table: "Notas",
                newName: "IdNotaDisciplina");

            migrationBuilder.RenameColumn(
                name: "NomeDiciplina",
                table: "Disciplinas",
                newName: "NomeDisciplina");

            migrationBuilder.RenameColumn(
                name: "IdDiciplina",
                table: "Disciplinas",
                newName: "IdDisciplina");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdNotaDisciplina",
                table: "Notas",
                newName: "IdNotaDiciplina");

            migrationBuilder.RenameColumn(
                name: "NomeDisciplina",
                table: "Disciplinas",
                newName: "NomeDiciplina");

            migrationBuilder.RenameColumn(
                name: "IdDisciplina",
                table: "Disciplinas",
                newName: "IdDiciplina");
        }
    }
}
