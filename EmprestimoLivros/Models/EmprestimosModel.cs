using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class EmprestimosModel //ESTRUTURA QUE ESTAMOS UTILIZANDO NO SQL 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Recebedor!")]  //ADICIONANDO O REQUIRED PARA EXIBIR CASO NÃO FOR INFORMADO OS DADOS NA HORA DO CADASTRO DO NOVO EMPRESTIMO
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Livro!")]
        public string LivroEmprestado { get; set; }
        public DateTime dataUltimaAtulizacao { get; set; } = DateTime.Now;

    }
}
