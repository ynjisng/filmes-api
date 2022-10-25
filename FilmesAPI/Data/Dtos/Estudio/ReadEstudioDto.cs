using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Estudio
{
    public class ReadEstudioDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime ConsultadoEm { get; set; }
    }
}
