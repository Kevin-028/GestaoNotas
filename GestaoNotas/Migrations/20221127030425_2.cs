using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoNotas.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Professores_ProfessorIdProfessor",
                table: "Disciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_ProfessorIdProfessor",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "ProfessorIdProfessor",
                table: "Disciplinas");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_IdProfessor",
                table: "Disciplinas",
                column: "IdProfessor");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Professores_IdProfessor",
                table: "Disciplinas",
                column: "IdProfessor",
                principalTable: "Professores",
                principalColumn: "IdProfessor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Professores_IdProfessor",
                table: "Disciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Disciplinas_IdProfessor",
                table: "Disciplinas");

            migrationBuilder.AddColumn<int>(
                name: "ProfessorIdProfessor",
                table: "Disciplinas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorIdProfessor",
                table: "Disciplinas",
                column: "ProfessorIdProfessor");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Professores_ProfessorIdProfessor",
                table: "Disciplinas",
                column: "ProfessorIdProfessor",
                principalTable: "Professores",
                principalColumn: "IdProfessor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
