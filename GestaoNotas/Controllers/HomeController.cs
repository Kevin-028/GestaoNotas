using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models;
using GestaoNotas.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GestaoNotas.Models.Adpter;
using System.Linq;
using System.Data.SqlTypes;

namespace GestaoNotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;

        private readonly ITurmaRepository _turmaRepository;

        private readonly IProfRepository _profRepository;

        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger, IAlunoRepository alunoRepository, ITurmaRepository turmaRepository, IProfRepository profRepository)
        {
            _logger = logger;
            _alunoRepository = alunoRepository;
            _turmaRepository = turmaRepository;
            _profRepository = profRepository;

        }


        public IActionResult Index()
        {
            List<alunoViewModel> alunos = _alunoRepository.GetAlunoViewModels();

            var a = new List<alunoViewModel>();



            //List<alunoViewModel> alunoViewModels = Adapter.ToAluno(alunos);

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

        //[HttpPost]
        //public IActionResult CriarAluno(alunoViewModel view)
        //{
        //    Aluno aluno = new Aluno(view.Nome, view.Email, view.Campus, view.Cpf, view.Telefone, view.Sexo, view.Endereco, view.Renda);
        //    _alunoRepository.adcionar(aluno);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult CriarAluno(alunoViewModel view)
        {

            Aluno aluno = Adapter.ToAluno(view);

            _alunoRepository.adcionar(aluno);

            return RedirectToAction("~/home/sucesso");
        }

        //public IActionResult CriarTurma(Turma turma)
        //{
        //    Turma aluno = new Aluno(view.Nome, view.Email, view.Campus, view.Cpf, view.Telefone, view.Sexo, view.Endereco, view.Renda);


        //    _turmaRepository.adcionar(turma);

        //    return RedirectToAction("Index");
        //}

        public IActionResult CriarProf(ProfViewModel view)
        {
            Professor professor = new Professor(view.Nome, view.Campus);


            _profRepository.adcionar(professor);

            return RedirectToAction("Index");
        }



    }
}