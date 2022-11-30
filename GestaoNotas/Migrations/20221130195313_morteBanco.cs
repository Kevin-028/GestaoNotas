using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoNotas.Migrations
{
    /// <inheritdoc />
    public partial class morteBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTurmaa",
                table: "Gestao_Alunos",
                newName: "IdTurma");

            migrationBuilder.RenameColumn(
                name: "IdNotaDisciplinaa",
                table: "Gestao_Alunos",
                newName: "IdNotaDisciplina");

            migrationBuilder.CreateIndex(
                name: "IX_Gestao_Alunos_IdTurma",
                table: "Gestao_Alunos",
                column: "IdTurma");

            migrationBuilder.AddForeignKey(
                name: "FK_Gestao_Alunos_Turmas_IdTurma",
                table: "Gestao_Alunos",
                column: "IdTurma",
                principalTable: "Turmas",
                principalColumn: "IdTurma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gestao_Alunos_Turmas_IdTurma",
                table: "Gestao_Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Gestao_Alunos_IdTurma",
                table: "Gestao_Alunos");

            migrationBuilder.RenameColumn(
                name: "IdTurma",
                table: "Gestao_Alunos",
                newName: "IdTurmaa");

            migrationBuilder.RenameColumn(
                name: "IdNotaDisciplina",
                table: "Gestao_Alunos",
                newName: "IdNotaDisciplinaa");
        }
    }
}
