using System.Web.Mvc;
using Ejemplo.MVC.Dominio.Entidades;
using Ejemplo.MVC.Dominio.Repositorios;

namespace Ejemplo.MVC.Controllers
{
    public class ClientesController : Controller
    {
        //link de referencia: https://docs.microsoft.com/es-es/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/implementing-basic-crud-functionality-with-the-entity-framework-in-asp-net-mvc-application#overpost

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
        [ValidateAntiForgeryToken]//el ValidateAntiForgeryToken atributo ayuda a evitar falsificación de solicitudes entre sitios ataques. Requiere su correspondiente Html.AntiForgeryToken() instrucción en la vista.
        public ActionResult Nuevo(Cliente cliente)
        {
            _clientesRepositorio.Agregar(cliente);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Detalle(int id)
        {
            var cliente = _clientesRepositorio.Obtener(id);

            return View(cliente);
        }

        public ActionResult Modificar(int id)
        {
            var cliente = _clientesRepositorio.Obtener(id);

            ViewBag.Localidades = _localidadesRepositorio.Obtener();
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//el ValidateAntiForgeryToken atributo ayuda a evitar falsificación de solicitudes entre sitios ataques. Requiere su correspondiente Html.AntiForgeryToken() instrucción en la vista.
        public ActionResult Modificar(Cliente cliente)
        {
            _clientesRepositorio.Modificar(cliente);

            return RedirectToAction("Index", "Home");
        }
    }
}