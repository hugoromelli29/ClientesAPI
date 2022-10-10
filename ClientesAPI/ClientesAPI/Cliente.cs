using System.ComponentModel.DataAnnotations;

namespace ClientesAPI
{
    public class Cliente
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Documento é obrigatório")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [RegularExpression("[(]?[0-9]{2}[)]?[0-9]{4,5}-?[0-9]{4}", 
            ErrorMessage = "Preencher o campo no formato de celular (xx)xxxxx-xxxx ou fixo (xx)xxxx-xxxx")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Endereço { get; set; }
    }
}
