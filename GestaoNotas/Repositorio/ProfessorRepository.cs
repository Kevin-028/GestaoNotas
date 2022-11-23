using Gestao.dominio;
using GestaoNotas.Data;

namespace GestaoNotas.Repositorio
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

            _bancoContext.Professor.Add(professor);

            _bancoContext.SaveChanges();

            return professor;
        }
    }
}
