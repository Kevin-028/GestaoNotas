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

        private readonly ITurmaRepository _turmaRepository;

        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //List<Aluno> alunos = _alunoRepository.GetAll();

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
        public IActionResult CadastroTurma()
        {
            return View();
        }
        public IActionResult CadastroProf()
        {
            return View();
        }
        public IActionResult CadastroDisciplina()
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

            //_alunoRepository.adcionar(aluno);

            return RedirectToAction("Index");
        }   
        public IActionResult CriarTurma(Turma turma)
        {
            _turmaRepository.adcionar(turma);

            return RedirectToAction("Index");
        }


    }
}