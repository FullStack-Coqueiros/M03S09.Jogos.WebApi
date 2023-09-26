using M03S09.Jogos.WebApi.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace M03S09.Jogos.WebApi.DTOs.Jogos
{
    public class UpdateJogoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataLancamento { get; set; }
        [Required]
        public ECategoriaJogo Categoria { get; set; }
        [Required]
        public int EstudioId { get; set; }
    }
}
