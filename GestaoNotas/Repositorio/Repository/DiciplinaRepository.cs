using Dapper;
using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

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

        public List<DisciplicaViewModel> GetDesciplinaViewModels()
        {
            var a = _bancoContext.Database.GetDbConnection().Query<DisciplicaViewModel>($"SELECT d.NomeDisciplina,d.DataAvaliacao,t.Descricao,d.IdDisciplina,p.Nome FROM [Disciplinas] d inner join Turmas t on t.IdTurma = d.IdTurma inner join Professores p on p.IdProfessor = d.IdProfessor").ToList();
            return a;
        }
    }
}
