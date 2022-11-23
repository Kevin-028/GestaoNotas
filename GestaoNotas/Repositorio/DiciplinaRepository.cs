using Gestao.dominio;
using GestaoNotas.Data;

namespace GestaoNotas.Repositorio
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
            _bancoContext.Disciplina.Add(diciplina);
            _bancoContext.SaveChanges();

            return diciplina;
        }

    }
}
