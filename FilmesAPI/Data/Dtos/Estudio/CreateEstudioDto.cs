using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Estudio
{
    public class CreateEstudioDto
    {
        [Required(ErrorMessage = "O campo 'Título' não pode ser vazio")]
        public string Nome { get; set; }
    }
}
