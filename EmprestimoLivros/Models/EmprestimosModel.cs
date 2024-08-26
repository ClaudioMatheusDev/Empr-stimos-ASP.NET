namespace EmprestimoLivros.Models
{
    public class EmprestimosModel //ESTRUTURA QUE ESTAMOS UTILIZANDO NO SQL 
    {
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string LivroEmprestado { get; set; }
        public DateTime dataUltimaAtulizacao { get; set; } = DateTime.Now;

    }
}
