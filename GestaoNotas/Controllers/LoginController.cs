using GestaoNotas.gestao;
using GestaoNotas.IRepository;
using GestaoNotas.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using GestaoNotas.Models.Adpter;
using GestaoNotas.Repositorio.IRepository;

namespace GestaoNotas.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILoginRepository _ILoginRepository;

        private readonly ILogger<LoginController> _logger;


        public LoginController(ILogger<LoginController> logger, ILoginRepository loginRepository)
        {
            _logger = logger;
            _ILoginRepository = loginRepository;

        }
        // GET: LoginController
        public ActionResult Index()
        {
            ViewBag.tema = "_Login";

            return View();
        }

        [HttpPost]
        public JsonResult BuscaLogin(LoginViewModel view)
        {

            Login login = Adapter.Tologin(view);

            var a = _ILoginRepository.GetLogin(login);

            var result = new
            {
                Email = a.Email,
                Tipo = a.perfil,
            };

            return Json(result);

        }

    }
}
