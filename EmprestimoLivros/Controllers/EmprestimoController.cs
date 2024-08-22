using EmprestimoLivros.Data;
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
            return View();
        }
    }
}
