using Dapper;
using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models.Adpter;
using GestaoNotas.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace GestaoNotas.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly BancoContext _bancoContext;
        public AlunoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public bool adcionar(Aluno aluno)
        {
            //add no banco de dados
            _bancoContext.Alunos.Add(aluno);

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

        public List<Aluno> GetAll()
        {
            return _bancoContext.Alunos.ToList();
        }

        public List<alunoViewModel> GetAlunoViewModels()
        {
            var a = _bancoContext.Database.GetDbConnection().Query<alunoViewModel>($"SELECT * FROM Gestao_alunos").ToList() ;
            return a;
        }

        public alunoViewModel GetAluno(int id)
        {
            var SQL = $"Select * from Gestao_alunos where IdAluno = @id";

            alunoViewModel aluno = _bancoContext.Database.GetDbConnection().Query<alunoViewModel>($"Select * from Gestao_alunos where IdAluno = @id", id).FirstOrDefault();

            return aluno;
        }

        public bool Update(alunoViewModel view)
        {
            throw new NotImplementedException();
        }
    }
}
