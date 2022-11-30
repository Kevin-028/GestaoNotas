using GestaoNotas.gestao;
using GestaoNotas.Models.ViewModel;
using System.Data.Common;

namespace GestaoNotas.IRepository
{
    public interface IAlunoRepository
    {
        List<Aluno> GetAll();
        List<alunoViewModel> GetAlunoViewModels();
        bool adcionar(Aluno aluno);

        alunoViewModel GetAluno(int id);

        bool Update(alunoViewModel view);


    }
}
