using M03S09.Jogos.WebApi.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace M03S09.Jogos.WebApi.Infra
{

    public class JogoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=coqueiros0309.Jogo;Trusted_Connection=True;TrustServerCertificate=True;User Id=lab365;Password=mithrandir;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstudioConfiguration());
            modelBuilder.ApplyConfiguration(new JogoConfiguration());
        }
    }
}
