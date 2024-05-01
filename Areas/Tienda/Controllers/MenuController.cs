using Microsoft.AspNetCore.Mvc;
using Market.Areas.Tienda.Interfaces;

namespace Market.Areas.Tienda.Controllers
{
    [Area("Tienda")]
    public class MenuController : Controller
    {
        private readonly IMenu _menu;
        public MenuController(IMenu menu)
        {
            _menu = menu;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetMenu()
        
        {
            var menu = _menu.GetMenus;
            return PartialView("_MenuPartial", menu);
        }
    }
}
