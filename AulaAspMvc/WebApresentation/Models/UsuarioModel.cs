using System.ComponentModel.DataAnnotations;

namespace WebApresentation.Models
{
    public class UsuarioModel
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome:")]
        [MaxLength(150, ErrorMessage = "Campo com tamanho maximo de 10 caracteres")]
        public string sNome { get; set; }

        [Required]
        [Display(Name ="Login")]
        [MaxLength(20, ErrorMessage ="Tamanho maximo de 20 caracteres")]
        public string sLogin { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [MaxLength(20, ErrorMessage = "Tamanho maximo de 20 caracteres")]
        public string sSenha { get; set; }
        [Display(Name ="Ativo")]
        public bool fAtivo { get; set; }
    }
}