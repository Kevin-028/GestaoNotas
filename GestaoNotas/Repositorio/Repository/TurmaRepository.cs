using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;

namespace GestaoNotas.Repository
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly BancoContext _bancoContext;
        public TurmaRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Turma adcionar(Turma turma)
        {
            //add no banco de dados


            _bancoContext.Turmas.Add(turma);
            _bancoContext.SaveChanges();

            return turma;
        }

    }
}
