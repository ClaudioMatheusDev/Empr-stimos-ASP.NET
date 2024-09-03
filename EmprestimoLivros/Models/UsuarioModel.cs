namespace EmprestimoLivros.Models
{
    public class UsuarioModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public byte[] SenhaHash { get; set; }//É A SENHA CRIPTOGRAFADA
        public byte[] SenhaSalt { get; set; }//CHAVE PARA A SENHA CRIPTOGRAFADA

    }
}
