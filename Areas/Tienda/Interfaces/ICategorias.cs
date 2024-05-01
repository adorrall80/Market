using Market.Areas.Tienda.Modelos;
using Market.Areas.Tienda.ViewModels;

namespace Market.Areas.Tienda.Interfaces
{
    public interface ICategorias
    {
        List<CategoriaViewModel> CategoriasTotales { get; }

       string GetCategoria(int id);

    }
}
