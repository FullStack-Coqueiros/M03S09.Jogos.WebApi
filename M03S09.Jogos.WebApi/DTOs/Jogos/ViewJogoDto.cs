using M03S09.Jogos.WebApi.Domain.Enums;

namespace M03S09.Jogos.WebApi.DTOs.Jogos
{
    public class ViewJogoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public ECategoriaJogo Categoria { get; set; }
        public int EstudioId { get; set; }
    }
}
