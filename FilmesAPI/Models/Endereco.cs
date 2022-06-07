using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Rua' não pode ser vazio")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo 'Bairro' não pode ser vazio")]
        public string Bairro { get; set; }

        [StringLength(50, ErrorMessage = "O campo 'Número' não pode passar de 50 caracteres")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo 'Cep' não pode ser vazio")]
        public int Cep { get; set; }
        
    }
}
