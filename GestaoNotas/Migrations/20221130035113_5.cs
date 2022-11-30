using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoNotas.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gestao_Alunos_Notas_IdNotaDiciplina",
                table: "Gestao_Alunos");

            migrationBuilder.RenameColumn(
                name: "IdNotaDiciplina",
                table: "Gestao_Alunos",
                newName: "IdNotaDisciplina");

            migrationBuilder.RenameIndex(
                name: "IX_Gestao_Alunos_IdNotaDiciplina",
                table: "Gestao_Alunos",
                newName: "IX_Gestao_Alunos_IdNotaDisciplina");

            migrationBuilder.AddForeignKey(
                name: "FK_Gestao_Alunos_Notas_IdNotaDisciplina",
                table: "Gestao_Alunos",
                column: "IdNotaDisciplina",
                principalTable: "Notas",
                principalColumn: "IdNotaDisciplina");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gestao_Alunos_Notas_IdNotaDisciplina",
                table: "Gestao_Alunos");

            migrationBuilder.RenameColumn(
                name: "IdNotaDisciplina",
                table: "Gestao_Alunos",
                newName: "IdNotaDiciplina");

            migrationBuilder.RenameIndex(
                name: "IX_Gestao_Alunos_IdNotaDisciplina",
                table: "Gestao_Alunos",
                newName: "IX_Gestao_Alunos_IdNotaDiciplina");

            migrationBuilder.AddForeignKey(
                name: "FK_Gestao_Alunos_Notas_IdNotaDiciplina",
                table: "Gestao_Alunos",
                column: "IdNotaDiciplina",
                principalTable: "Notas",
                principalColumn: "IdNotaDisciplina");
        }
    }
}
