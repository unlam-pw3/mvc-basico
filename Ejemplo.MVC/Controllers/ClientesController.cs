using System.Web.Mvc;
using Ejemplo.MVC.Dominio.Entidades;
using Ejemplo.MVC.Dominio.Repositorios;

namespace Ejemplo.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClientesRepositorio _clientesRepositorio;
        private readonly LocalidadesRepositorio _localidadesRepositorio;

        public ClientesController()
        {
            _clientesRepositorio = new ClientesRepositorio();
            _localidadesRepositorio = new LocalidadesRepositorio();
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            ViewBag.Localidades = _localidadesRepositorio.Obtener();
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(Cliente cliente)
        {
            _clientesRepositorio.Guardar(cliente);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Detalle(int id)
        {
            var cliente = _clientesRepositorio.Obtener(id);

            return View(cliente);

        }
    }
}