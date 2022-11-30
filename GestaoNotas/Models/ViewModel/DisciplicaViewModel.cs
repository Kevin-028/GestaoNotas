using GestaoNotas.gestao;
using System.ComponentModel.DataAnnotations;

namespace GestaoNotas.Models.ViewModel
{
    public class DisciplicaViewModel
    {
        public int IdDiciplina { get; set; }

        [Display(Name = "Nome da Disciplina")]
        public string NomeDisciplina { get; set; }

        [Display(Name = "Data Avaliação")]
        public string DataAvaliacao { get; set; }
        public int IdTurma { get; set; }

        [Display(Name = "Nome da Turma")]
        public string Descricao { get; set; }
        public int IdProfessor { get; set; }

        [Display(Name = "Nome Professor")]
        public string Nome { get; set; }

        public List<NotaDiciplina> Nota { get; set; }

    }
}
