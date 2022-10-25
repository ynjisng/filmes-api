using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Avaliacao
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Título' não pode ser vazio")]
        public Filme Titulo { get; set; }

        public string Descricao { get; set; }

        [Range(0, 5, ErrorMessage = "A nota deve ter no mínimo 0 e no máximo 5 pontos")]
        public int Nota { get; set; }
        public DateTime criado_em { get; set; }
        public DateTime atualizado_em { get; set; }
    }
}
