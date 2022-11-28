using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;

namespace GestaoNotas.Repository
{
    public class NotaDisciplinaRepository : INotaDisciplinaRepository
    {
        private readonly BancoContext _bancoContext;
        public NotaDisciplinaRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public NotaDiciplina adcionar(NotaDiciplina notaDiciplina)
        {
            _bancoContext.NotaDiciplinas.Add(notaDiciplina);
            _bancoContext.SaveChanges();

            return notaDiciplina;
        }
    }
}
