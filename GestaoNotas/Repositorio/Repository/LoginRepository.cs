using Dapper;
using GestaoNotas.Data;
using GestaoNotas.gestao;
using GestaoNotas.Models.ViewModel;
using GestaoNotas.Repositorio.IRepository;
using Microsoft.EntityFrameworkCore;

namespace GestaoNotas.Repositorio.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly BancoContext _bancoContext;
        public LoginRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Login GetLogin(Login login)
        {

            var SQL = $"Select * from Gestao_alunos where IdAluno = @id";

            Login a = _bancoContext.Database.GetDbConnection().Query<Login>($"Select * from Logins where Email = '" + login.Email + "' and Senha = '" + login.Senha + "'").FirstOrDefault();

            //Login b = _bancoContext.Logins.Where(x => x.Email== email).FirstOrDefault();

            return a;

        }
    }
}
