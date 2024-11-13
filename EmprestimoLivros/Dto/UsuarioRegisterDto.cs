using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Dto
{
    public class UsuarioRegisterDto
    {
        [Required(ErrorMessage = "Digite o Nome!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Digite o SobreNome!")]
        public string Sobrenome { get; set; }


        [Required(ErrorMessage = "Digite um Email!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Digite uma Senha!")]
        public string Senha { get; set; }


        [Required(ErrorMessage = "Digite a Confirmação de enha!")]
        public string ConfirmaSenha { get; set; }
    }
}
