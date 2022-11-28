using GestaoNotas.gestao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoNotas.Data.map
{
    public class NotaDisciplinaMap : IEntityTypeConfiguration<NotaDiciplina>
    {

        public void Configure(EntityTypeBuilder<NotaDiciplina> builder)
        {
            builder.HasKey(x => x.IdNotaDiciplina);

            builder.HasOne(x => x.Disciplina)
                .WithMany(y => y.NotaDiciplinas)
                .HasForeignKey(k => k.IdDisciplina)
                .IsRequired(false);


            builder.ToTable("Notas");

        }
    }
}
