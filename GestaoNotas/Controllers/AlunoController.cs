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
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;

        private readonly ITurmaRepository _turmaRepository;

        private readonly IProfRepository _profRepository;

        private readonly IDiciplinaRepository _disciplinaRepository;

        private readonly ILogger<HomeController> _logger;

        public AlunoController(ILogger<HomeController> logger, IAlunoRepository alunoRepository, ITurmaRepository turmaRepository, IProfRepository profRepository, IDiciplinaRepository disciplinaRepository)
        {
            _logger = logger;
            _alunoRepository = alunoRepository;
            _turmaRepository = turmaRepository;
            _profRepository = profRepository;
            _disciplinaRepository = disciplinaRepository;

        }
        public IActionResult Index()
        {
            ViewBag.tema = "_Layout2";

            return View();
        }   
        public IActionResult Editar()
        {
            ViewBag.tema = "_Layout2";

            return View();
        }     
        public IActionResult NotasTurma()
        {
            ViewBag.tema = "_Layout2";

            return View();
        }
    }
}