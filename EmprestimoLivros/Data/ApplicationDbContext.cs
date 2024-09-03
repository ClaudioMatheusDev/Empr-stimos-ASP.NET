using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; } //CRIANDO A TABELA EMPRESTIMOS
        public DbSet<UsuarioModel> Usuarios { get; set; }//CRIANDO A TABELA USUARIOS


    }
}
 