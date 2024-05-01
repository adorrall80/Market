using Market.Areas.Tienda.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Market.Areas.Tienda.Controllers
{
    [Area("Tienda")]
    public class ProductoController : Controller
    {
        private readonly IProductos _productos;
        public ProductoController(IProductos productos)
        {
            _productos = productos;
        }

        public IActionResult Index()
        {
            var local = _productos.GetProductos();
        return PartialView("_ListadoProductosPartial", local);
        }
        public IActionResult GetProductoxCategorias(int id)
        {
            var producto = _productos.GetProductoxCategorias(id);


            return View("_ListadoProductosPartial", producto);
        }
    }
}
