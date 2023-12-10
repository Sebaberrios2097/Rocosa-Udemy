using Microsoft.AspNetCore.Mvc;
using Rocosa_Udemy.Datos;
using Rocosa_Udemy.Models;

namespace Rocosa_Udemy.Controllers
{
    public class TipoAplicacionController : Controller
    {
        public readonly ApplicationDbContext _db;

        public TipoAplicacionController(ApplicationDbContext db)
        {
            _db = db;   
        }

        public IActionResult Index()
        {
            IEnumerable<TipoAplicacion> lista = _db.TipoAplicacion;
            return View(lista);
        }

        // Get
        public IActionResult Crear()
        {
            return View();
        }

        // Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(TipoAplicacion tipoAplicacion)
        {
            _db.Add(tipoAplicacion);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
