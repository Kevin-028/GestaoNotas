using GestaoNotas.gestao;

namespace GestaoNotas.Models.ViewModel
{
    public class ProfViewModel
    {
        public int IdProfessor { get;  set; }
        public string Campus { get;  set; }
        public string Nome { get;  set; }
        public List<Disciplina> _disciplina { get; set; }
    }
}
