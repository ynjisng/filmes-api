using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Estudio
{
    public class UpdateEstudioDto
    {
        [Required(ErrorMessage = "O campo 'Título' não pode ser vazio")]
        public string Nome { get; set; }
    }
}
