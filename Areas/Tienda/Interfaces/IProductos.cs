using Market.Areas.Tienda.ViewModels;


namespace Market.Areas.Tienda.Interfaces
{
    public interface IProductos
    {
        List<ProductosViewModel> productos();
        List<ProductosViewModel> GetProductos();
        List<ProductosViewModel> GetProductoxCategorias(int IdCategoria);
    }
}
