using Gestao.dominio;
using GestaoNotas.Data.map;
using Microsoft.EntityFrameworkCore;

namespace GestaoNotas.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options):base(options)
        { 
        
        }   
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turma> Turma { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
