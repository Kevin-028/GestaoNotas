using Gestao.dominio;
using GestaoNotas.Data;

namespace GestaoNotas.Repositorio
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


            _bancoContext.Turma.Add(turma);
            _bancoContext.SaveChanges();

            return turma;
        }

    }
}
