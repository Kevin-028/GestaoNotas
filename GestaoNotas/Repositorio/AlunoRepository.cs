using Gestao.dominio;
using GestaoNotas.Data;

namespace GestaoNotas.Repositorio
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly BancoContext _bancoContext;
        public AlunoRepository(BancoContext bancoContext) 
        { 
            _bancoContext = bancoContext;
        }

        public Aluno adcionar(Aluno aluno)
        {
            //add no banco de dados
            _bancoContext.Alunos.Add(aluno);
            _bancoContext.SaveChanges();

            return aluno;
        }
    }
}
