using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;

namespace GestaoNotas.Repository
{
    public class DiciplinaRepository : IDiciplinaRepository
    {
        private readonly BancoContext _bancoContext;
        public DiciplinaRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Disciplina adcionar(Disciplina diciplina)
        {
            //add no banco de dados
            _bancoContext.Disciplinas.Add(diciplina);
            _bancoContext.SaveChanges();

            return diciplina;
        }


    }
}
