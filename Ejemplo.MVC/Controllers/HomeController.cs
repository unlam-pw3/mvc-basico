using System.Web.Mvc;
using Ejemplo.MVC.Dominio.Repositorios;

namespace Ejemplo.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClientesRepositorio _repositorio;

        public HomeController()
        {
            _repositorio = new ClientesRepositorio();
        }

        public ActionResult Index()
        {
            var clientes = _repositorio.Obtener();

            return View(clientes);
        }
    }
}