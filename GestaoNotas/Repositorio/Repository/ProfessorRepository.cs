using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;

namespace GestaoNotas.Repository
{
    public class ProfessorRepository : IProfRepository
    {
        private readonly BancoContext _bancoContext;
        public ProfessorRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Professor adcionar(Professor professor)
        {
            //add no banco de dados

            _bancoContext.Professores.Add(professor);

            _bancoContext.SaveChanges();

            return professor;
        }
    }
}
