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
            var local = _productos.GetProductosTodos();
        return PartialView("_ListadoProductosPartial", local);
        }
        public IActionResult GetProductoxCategorias(int IdCategoria)
        {
            var producto = _productos.GetProductoxCategorias(IdCategoria);


            return View("_ListadoProductosPartial", producto);
        }
        public IActionResult GetDetalleProducto(int id)
        {
            var producto = _productos.GetProducto(id);
            return View("_DetalleProductoPartial",producto);
        }
    }
}
