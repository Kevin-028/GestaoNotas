using GestaoNotas.gestao;

namespace GestaoNotas.Models.ViewModel
{
    public class TurmaViewModel
    {
        public int IdTurma { get; set; }
        public string Descricao { get; set; }
        public string Coordenador { get; set; }

        public List<Aluno> Alunos {get;set;}
        public  List<Disciplina> Disciplinas { get; set; }

    }
}
