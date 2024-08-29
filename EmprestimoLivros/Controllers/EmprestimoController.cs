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
        } //INICIANDO A CONEXÃO COM O BANCO DE DADOS


        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;//entrando no banco de dados e pegando a tabela inteira do emprestimos

            return View(emprestimos);

        }//RETORNANDO NOSSA INDEX E IMPRIMINDO A TABELAS COM OS DADOS

        [HttpGet]//ACTION COM O MESMO NOME CADASTRAR, A MESMA AUTOMATICAMENTE ESTÁ RETORNANDO O METODO GET
        public IActionResult Cadastrar()
        {
            return View();
        }//CADASTRAR HTTPGET, RETORNANDO A TELA DE CADASTRO

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0) //Verificando se o ID é nulo ou zero, caso for, retorna um erro 
            {
                return NotFound();
            }

            EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id); // X => X. É IGUAL ENTRAR NO BANCO DE DADOS E PEGAR TUDO, TODAS TABELAS E COLUNAS

            if (emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        } //EDITAR 


        [HttpGet]
        public IActionResult Excluir(int? id) //EXCLUIR PASSANDO O ID DO EMPRESTIMO PARA EXCLUIR
        {
            if (id == null || id == 0) //Verificando se o ID é nulo ou zero, caso for, retorna um erro 
            {
                return NotFound();
            }

            EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id); //O X SERIA AS TABELAS E COLUNAS 
       
        
            if (emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        
        }//EXCLUIR


        [HttpPost] //ADICIONANDO O HTTPPOST EM CIMA DA ACTION, DECLARAMOS QUE A MESMA ESTÁ ENVIANDO DADOS, ENTÃO ESTÁ RETORNANDO UM METODO POST
        public IActionResult Cadastrar(EmprestimosModel emprestimos)
        {
            if (ModelState.IsValid)//Se o status da model for valido (se a conexão do banco de dados for valida) 
            {
                _db.Emprestimos.Add(emprestimos); //Entrando no banco de dados, na tabela emprestimo e adicionado novas informações
                _db.SaveChanges(); //Entrando no banco de dados e salvando as novas informações adicionadas

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";//MENSAGEM DE SUCESSO DA EXCLUSÃO, EDIÇÃO E CADASTRO


                return RedirectToAction("Index"); //Depois de tudo salvo, redireciona o usuario para a pagina index
            }
            TempData["MensagemError"] = "Cadastro não foi realizado com sucesso!";

            return View(); //CASO O IF NÃO FOR VALIDO, O MESMO RETORNA O USUARIO PARA A VIEW(CADASTRAR) 

        } // CADASTRAR


        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Update(emprestimo);//ENTRANDO NO BANCO DE DADOS, NA TABELA EMPRESTIMO E MODIFICANDO APENAS O emprestimo SELECIONADO
                _db.SaveChanges();//Entrando no banco de dados e salvando as novas informações modificadas

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!"; //MENSAGEM DE SUCESSO DA EXCLUSÃO, EDIÇÃO E CADASTRO

                return RedirectToAction("Index");// Depois de tudo salvo, redireciona o usuario para a pagina index
            }

            TempData["MensagemError"] = "Edição não foi realizada com sucesso!";

            return View(emprestimo); //CASO NÃO FOR VALIDO, RETORNA SEMPRE PARA A PAGINA DE ATUALIZAR O EMPRESTIMO

        }//EDITAR 

        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {
            if (emprestimo == null)
            {
                return NotFound();

            }

            _db.Emprestimos.Remove(emprestimo);//ENTRANDO NO BANCOS DE DADOS E EXCLUINDO O DADO
            _db.SaveChanges();//Entrando no banco de dados e salvando as informações excluidas

            TempData["MensagemSucesso"] = "Remoção realizada com sucesso!"; //MENSAGEM DE SUCESSO DA EXCLUSÃO, EDIÇÃO E CADASTRO

            return RedirectToAction("Index");// Depois de tudo salvo, redireciona o usuario para a pagina index

        }

    }
}
