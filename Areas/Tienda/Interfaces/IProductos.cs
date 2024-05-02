using Market.Areas.Tienda.ViewModels;


namespace Market.Areas.Tienda.Interfaces
{
    public interface IProductos
    {
        
        
        List<ProductosViewModel> GetProductoxCategorias(int IdCategoria);
        List<ProductosViewModel> GetProductosTodos();
        ProductosViewModel GetProducto(int id);
    }
}
