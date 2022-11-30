using Dapper;
using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestaoNotas.Repository
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly BancoContext _bancoContext;
        public TurmaRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public bool adcionar(Turma turma)
        {
            //add no banco de dados
            _bancoContext.Turmas.Add(turma);

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

        public bool CadastroAluno(alunoViewModel view)
        {

            Aluno aluno = _bancoContext.Alunos.Where(a => a.IdAluno == view.IdAluno).ToList().FirstOrDefault();

            Turma turma = _bancoContext.Turmas.Where(a => a.IdTurma == view.IdTurma).ToList().FirstOrDefault();

            turma.AddAluno(aluno);
            
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
        public List<TurmaViewModel> GetTurmaViewModels()
        {
            var a = _bancoContext.Database.GetDbConnection().Query<TurmaViewModel>($"SELECT * FROM Turmas").ToList();
            return a;
        }
    }

}
