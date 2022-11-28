using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoNotas.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gestao_Alunos_Notas_IdNotaDiciplina",
                table: "Gestao_Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gestao_Alunos_Turmas_IdTurma",
                table: "Gestao_Alunos");

            migrationBuilder.AddForeignKey(
                name: "FK_Gestao_Alunos_Notas_IdNotaDiciplina",
                table: "Gestao_Alunos",
                column: "IdNotaDiciplina",
                principalTable: "Notas",
                principalColumn: "IdNotaDiciplina");

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
                name: "FK_Gestao_Alunos_Notas_IdNotaDiciplina",
                table: "Gestao_Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gestao_Alunos_Turmas_IdTurma",
                table: "Gestao_Alunos");

            migrationBuilder.AddForeignKey(
                name: "FK_Gestao_Alunos_Notas_IdNotaDiciplina",
                table: "Gestao_Alunos",
                column: "IdNotaDiciplina",
                principalTable: "Notas",
                principalColumn: "IdNotaDiciplina",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gestao_Alunos_Turmas_IdTurma",
                table: "Gestao_Alunos",
                column: "IdTurma",
                principalTable: "Turmas",
                principalColumn: "IdTurma",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
