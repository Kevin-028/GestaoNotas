using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoNotas.Migrations
{
    /// <inheritdoc />
    public partial class morteBanco1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Disciplinas_IdDisciplina",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "IdAlunoo",
                table: "Notas");

            migrationBuilder.RenameColumn(
                name: "IdDisciplinaa",
                table: "Notas",
                newName: "IdDisciplina");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaIdDisciplina",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Disciplinas_IdDisciplina",
                table: "Notas",
                column: "IdDisciplina",
                principalTable: "Disciplinas",
                principalColumn: "IdDisciplina",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Disciplinas_DisciplinaIdDisciplina",
                table: "Notas");

            migrationBuilder.RenameColumn(
                name: "IdDisciplina",
                table: "Notas",
                newName: "IdDisciplinaa");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaIdDisciplina",
                table: "Notas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdAlunoo",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Disciplinas_DisciplinaIdDisciplina",
                table: "Notas",
                column: "DisciplinaIdDisciplina",
                principalTable: "Disciplinas",
                principalColumn: "IdDisciplina");
        }
    }
}
