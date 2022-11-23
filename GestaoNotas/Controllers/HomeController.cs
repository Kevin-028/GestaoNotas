using Gestao.dominio;
using GestaoNotas.Models;
using GestaoNotas.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestaoNotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;

        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }     
        public IActionResult Cadastro()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CriarAluno(Aluno aluno)
        {
            _alunoRepository.adcionar(aluno);

            return RedirectToAction("Index");
        }

    }
}