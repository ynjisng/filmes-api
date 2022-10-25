using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos.Filme
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo 'Título' não pode ser vazio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo 'Diretor' não pode ser vazio")]
        public string Diretor { get; set; }

        [StringLength(100, ErrorMessage = "O campo 'Gênero' não pode passar de 100 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
