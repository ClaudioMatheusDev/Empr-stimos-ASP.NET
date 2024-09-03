using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Registrar()
        {

            return View();
        }
    }
}

