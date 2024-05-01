using Market.Areas.Tienda.ViewModels;

namespace Market.Areas.Tienda.Interfaces
{
    public interface IMenu
    {
        List<MenuViewModel> GetMenus { get; }
    }
}
