using Microsoft.AspNetCore.Mvc;
using Rocosa_Udemy.Datos;
using Rocosa_Udemy.Models;

namespace Rocosa_Udemy.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoriaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Categoria> lista = _db.Categoria;
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
        public IActionResult Crear(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _db.Categoria.Add(categoria);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
            
        }

        // Get
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Categoria.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // Post
    }
}
