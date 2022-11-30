using System.ComponentModel.DataAnnotations;

namespace GestaoNotas.Models.ViewModel
{
    public class AddTurmaAlunoViewModel
    {
        public int IdAluno { get; set; }
        public int IdTurma { get; set; }

        [Display(Name = "Nome da Turma")]
        public string Descricao { get; set; }
    }
}
