using GestaoNotas.Data.map;
using GestaoNotas.gestao;
using Microsoft.EntityFrameworkCore;

namespace GestaoNotas.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<NotaDiciplina> NotaDiciplinas{get; set;}
        public DbSet<Login> Logins{get; set;}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoContext).Assembly);

            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new NotaDisciplinaMap());
            modelBuilder.ApplyConfiguration(new LoginMap());



            base.OnModelCreating(modelBuilder);
        }
    }
}
