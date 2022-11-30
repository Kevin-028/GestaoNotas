using GestaoNotas.gestao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoNotas.Data.map
{
    public class DisciplinaMap : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder.HasKey(x => x.IdDisciplina);

            builder.HasOne(x => x.Turma)
                .WithMany(y => y.Disciplinas)
                .HasForeignKey(k => k.IdTurma);

            builder.HasOne(x => x.Professor)
                .WithMany(y => y.Disciplina)
                .HasForeignKey(k => k.IdProfessor);

        }
    }
}
