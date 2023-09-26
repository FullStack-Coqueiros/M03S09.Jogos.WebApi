using M03S09.Jogos.WebApi.Domain;
using M03S09.Jogos.WebApi.Infra;
using Microsoft.EntityFrameworkCore;

namespace M03S09.Jogos.WebApi.Repositories
{
    public class JogoRepository
    {
        private readonly JogoDbContext _jogoDbContext;

        public JogoRepository(JogoDbContext jogoDbContext)
        {
            _jogoDbContext = jogoDbContext;
        }

        public Jogo Get(int id)
        {
            var jogo = _jogoDbContext.Set<Jogo>().Where(p => p.Id == id)
                .FirstOrDefault();
            return jogo;
        }

        public List<Jogo> Get()
        {
            var jogo = _jogoDbContext.Set<Jogo>().ToList();
            return jogo;
        }

        public void Insert(Jogo jogo)
        {
            _jogoDbContext.Set<Jogo>().Add(jogo);
            _jogoDbContext.SaveChanges();
        }

        public void Update(Jogo jogo)
        {
            _jogoDbContext.ChangeTracker.Clear();
            _jogoDbContext.Entry(jogo).State = EntityState.Modified;
            _jogoDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var jogo = _jogoDbContext.Set<Jogo>().Where(p => p.Id == id)
                .First();
            _jogoDbContext.Set<Jogo>().Remove(jogo);
            _jogoDbContext.SaveChanges();
        }
    }
}
