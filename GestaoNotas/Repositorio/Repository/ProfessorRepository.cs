using Dapper;
using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace GestaoNotas.Repository
{
    public class ProfessorRepository : IProfRepository
    {
        private readonly BancoContext _bancoContext;
        public ProfessorRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public bool adcionar(Professor professor)
        {
            //add no banco de dados

            _bancoContext.Professores.Add(professor);

            try
            {
                _bancoContext.SaveChanges();

                return true;

            }
            catch
            {
                return false;

            }
        }

        public List<ProfViewModel> GetProfViewModels()
        {
            var a = _bancoContext.Database.GetDbConnection().Query<ProfViewModel>($"SELECT * FROM Professores").ToList();

            return a;
        }

    }
}
