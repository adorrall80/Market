using Microsoft.AspNetCore.Mvc;
using Market.Areas.Tienda.Interfaces;



namespace Market.Areas.Tienda.Controllers
{
    [Area("Tienda")]
    public class CategoriaController : Controller
    {
        private readonly ICategorias _categorias;
        public CategoriaController(ICategorias categorias)
        {
            _categorias = categorias;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCategoria(int id)
        {
            var categoria = _categorias.GetCategoria(id);
            return View(categoria);
        }
        public IActionResult GetCategorias()
        {
            var categoria = _categorias.CategoriasTotales;
            return PartialView("_ListadoCategoriasPartial", categoria);
        }
    }
}
