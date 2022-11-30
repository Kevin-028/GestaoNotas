using GestaoNotas.gestao;
using GestaoNotas.Models.ViewModel;

namespace GestaoNotas.IRepository
{
    public interface ITurmaRepository
    {
        bool adcionar(Turma turma);
        List<TurmaViewModel> GetTurmaViewModels();

        bool CadastroAluno(alunoViewModel aluno);

    }
}
