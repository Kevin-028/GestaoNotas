using GestaoNotas.gestao;
using GestaoNotas.Models.ViewModel;

namespace GestaoNotas.IRepository
{
    public interface IProfRepository
    {
        bool adcionar(Professor professor);

        List<ProfViewModel> GetProfViewModels();

    }
}
