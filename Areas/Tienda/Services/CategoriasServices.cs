using Market.Areas.Tienda.Interfaces;
using Market.Areas.Tienda.Modelos;
using Market.Areas.Tienda.ViewModels;

namespace Market.Areas.Tienda.Services
{
    public class CategoriasServices:ICategorias
    {
        public CategoriasServices()
        {

        }
        public List<CategoriaViewModel> Categorias()
        {
            var categorias = new List<CategoriaViewModel>();
            categorias.Add(new CategoriaViewModel { Id = 1, Nombre = "Ropa de Bebe" });
            categorias.Add(new CategoriaViewModel { Id = 2, Nombre = "Ropa Hombre" });
            categorias.Add(new CategoriaViewModel { Id = 3, Nombre = "Ropa Mujer" });

            return categorias;

         }
        public string GetCategoria(int id)
        {
            var categoria = Categorias().FirstOrDefault(x => x.Id == id);
            return "Categoria";
        }
        public List<CategoriaViewModel> CategoriasTotales => Categorias();

    }
}
