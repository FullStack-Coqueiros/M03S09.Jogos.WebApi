using M03S09.Jogos.WebApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M03S09.Jogos.WebApi.Infra.Configurations
{
    public class JogoConfiguration : IEntityTypeConfiguration<Jogo>
    {
        public void Configure(EntityTypeBuilder<Jogo> builder)
        {
            builder.ToTable("Jogos");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .UseIdentityColumn();

            builder.HasOne(p => p.Estudio)
                .WithMany(p => p.Jogos)
                .HasForeignKey(p => p.EstudioId);
        }
    }
}
