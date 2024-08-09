using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

    }
}
