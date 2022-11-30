using GestaoNotas.gestao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GestaoNotas.Data.map
{
    public class LoginMap : IEntityTypeConfiguration<Login>
    {
         public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(x => x.IdLogin);
        }
    }
}
