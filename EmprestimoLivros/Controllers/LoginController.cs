using EmprestimoLivros.Dto;
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
        [HttpPost]
        public IActionResult Registrar(UsuarioRegisterDto usuarioRegisterDto)
        {
            return View(usuarioRegisterDto);
        }






    }
}

