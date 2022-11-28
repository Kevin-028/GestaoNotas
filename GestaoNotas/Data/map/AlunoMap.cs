using GestaoNotas.gestao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoNotas.Data.map
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(x => x.IdAluno);

            builder.HasOne(x => x.Turma)
                .WithMany(y => y.Alunos)
                .HasForeignKey(k => k.IdTurma)
                .IsRequired(false);

            builder.HasOne(x => x.NotaDiciplina)
                .WithMany(y => y.Alunos)
                .HasForeignKey(k => k.IdNotaDiciplina)
                .IsRequired(false);


            builder.ToTable("Gestao_Alunos");

        }
    }

}
