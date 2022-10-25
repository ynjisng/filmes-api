using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Estudio
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' não pode ser vazio")]
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }   
}
