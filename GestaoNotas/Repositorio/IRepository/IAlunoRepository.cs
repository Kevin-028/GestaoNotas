using GestaoNotas.gestao;
using GestaoNotas.Models.ViewModel;
using System.Data.Common;

namespace GestaoNotas.IRepository
{
    public interface IAlunoRepository
    {
        List<Aluno> GetAll();
        List<alunoViewModel> GetAlunoViewModels();
        Aluno adcionar(Aluno aluno);
    }
}
