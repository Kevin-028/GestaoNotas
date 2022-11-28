using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models.Adpter;
using GestaoNotas.Models.ViewModel;

namespace GestaoNotas.Repository
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

        public List<Aluno> GetAll()
        {
            return _bancoContext.Alunos.ToList();
        }
        public List<alunoViewModel> GetAlunoViewModels()
        {
            return _bancoContext.AlunosViewModel.ToList();
        }
    }
}
