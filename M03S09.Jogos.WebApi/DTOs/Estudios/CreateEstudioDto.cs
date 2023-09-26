using System.ComponentModel.DataAnnotations;

namespace M03S09.Jogos.WebApi.DTOs.Estudios
{
    public class CreateEstudioDto
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Endereco { get; set; }
    }
}
