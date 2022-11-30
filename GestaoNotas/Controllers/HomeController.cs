using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models;
using GestaoNotas.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GestaoNotas.Models.Adpter;
using System.Linq;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Mvc.Rendering;
using GestaoNotas.Data;

namespace GestaoNotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;

        private readonly ITurmaRepository _turmaRepository;

        private readonly IProfRepository _profRepository;

        private readonly IDiciplinaRepository _disciplinaRepository;

        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger, IAlunoRepository alunoRepository, ITurmaRepository turmaRepository, IProfRepository profRepository, IDiciplinaRepository disciplinaRepository)
        {
            _logger = logger;
            _alunoRepository = alunoRepository;
            _turmaRepository = turmaRepository;
            _profRepository = profRepository;
            _disciplinaRepository = disciplinaRepository;

        }


        public IActionResult Index()
        {
            List<alunoViewModel> alunos = _alunoRepository.GetAlunoViewModels();

            //List<alunoViewModel> alunoViewModels = Adapter.ToAluno(alunos);
            ViewBag.tema = "_Layout";

            return View(alunos);
        }

        public IActionResult Cadastro()
        {
            ViewBag.tema = "_Layout";

            return View();
        }
        public IActionResult CadastroTurma()
        {
            List<TurmaViewModel> turma = _turmaRepository.GetTurmaViewModels();

            ViewBag.tema = "_Layout";

            return View();
        }
        public IActionResult CadastroProf()
        {
            ViewBag.tema = "_Layout";

            return View();
        }
        public IActionResult CadastroDisciplina()
        {


            ViewBag.tema = "_Layout";

            ViewBag.IdTurma = new SelectList(_turmaRepository.GetTurmaViewModels(), "IdTurma", "Descricao");
            ViewBag.IdProfessor = new SelectList(_profRepository.GetProfViewModels(), "IdProfessor", "Nome");


            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.tema = "_Layout";

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpPost]
        public JsonResult CriarAluno(alunoViewModel view)
        {

            Aluno aluno = Adapter.ToAluno(view);

            var a = _alunoRepository.adcionar(aluno);

            var result = new
            {
                Cadastrado = a
            };
            return Json(result);
        }

        [HttpPost]
        public JsonResult CadastroProf(ProfViewModel view)
        {
            Professor professor = Adapter.ToProf(view);

            var a = _profRepository.adcionar(professor);

            var result = new
            {
                Cadastrado = a
            };
            return Json(result);
        }      
        public JsonResult AddTurma(TurmaViewModel view)
        {
            Turma turma = Adapter.ToTurma(view);

            var a = _turmaRepository.adcionar(turma);

            var result = new
            {
                Cadastrado = a
            };
            return Json(result);
        }     
        public JsonResult addDisciplina(DisciplicaViewModel view)
        {
            Disciplina disciplina = Adapter.ToDisciplina(view);

            var a = _disciplinaRepository.adcionar(disciplina);

            var result = new
            {
                Cadastrado = a
            };
            return Json(result);
        }

        [HttpPost]
        public JsonResult addTurmaAluno(alunoViewModel view)
        {

            var a = _turmaRepository.CadastroAluno(view);

            var Result = new
            {
                data = a
            };

            return Json(Result);

        }   
        public PartialViewResult AddNotaAluno(DisciplicaViewModel view)
        {



            ViewBag.IdTurma = new SelectList(_turmaRepository.GetTurmaViewModels(), "IdTurma", "Descricao");

            ViewBag.IdProfessor = new SelectList(_profRepository.GetProfViewModels(), "IdProfessor", "Nome");
            

            return PartialView("_addNotaAluno");
        }      
        public PartialViewResult DisciplinaTabela()
        {

            List<DisciplicaViewModel> disciplina = _disciplinaRepository.GetDesciplinaViewModels();


            return PartialView("_DisciplinaTabela", disciplina);
        }  

        public PartialViewResult ProfTabela()
        {

            List<ProfViewModel> professor = _profRepository.GetProfViewModels();


            return PartialView("_ProfTabela", professor);
        }



    }
}