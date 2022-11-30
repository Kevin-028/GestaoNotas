using GestaoNotas.gestao;
using GestaoNotas.Models.ViewModel;

namespace GestaoNotas.IRepository
{
    public interface IDiciplinaRepository
    {
        Disciplina adcionar(Disciplina turma);
        List<DisciplicaViewModel> GetDesciplinaViewModels();

    }
}
