using Market.Areas.Tienda.Interfaces;
using Market.Areas.Tienda.ViewModels;

namespace Market.Areas.Tienda.Services
{
    public class MenuService: IMenu
    {
        public List<MenuViewModel> Menus()
        {
            return new List<MenuViewModel>
            {
                new MenuViewModel
                {
                    Id = 1,
                    Nombre = "Inicio",
                    Url = "/Tienda/Home/Index"
                },
                new MenuViewModel
                {
                    Id = 2,
                    Nombre = "Categorias",
                    Url = "/Tienda/Categorias/Index"
                },
                new MenuViewModel
                {
                    Id = 3,
                    Nombre = "Productos",
                    Url = "/Tienda/Productos/Index"
                }
            };
        }   
        public string GetMenu(int id)
        {
            var menu = Menus().FirstOrDefault(x => x.Id == id);
            return "Menu";
        }
        public List<MenuViewModel> GetMenus => Menus();
    }
}
