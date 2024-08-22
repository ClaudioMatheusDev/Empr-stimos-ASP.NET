using EmprestimoLivros.Data;
using EmprestimoLivros.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class EmprestimoController : Controller
    {

        readonly private ApplicationDbContext _db; //CRIANDO UMA PROPIEDADE PRIVADA 

        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel>  emprestimos = _db.Emprestimos;//entrando no banco de dados e pegando a tabela inteira do emprestimos

            return View(emprestimos);

        }
    }
}
