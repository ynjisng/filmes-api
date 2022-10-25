using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Endereco
{
    public class CreateEnderecoDto
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        [Required(ErrorMessage = "O campo 'CEP' não pode ser vazio")]
        public int Cep { get; set; }
    }
}
