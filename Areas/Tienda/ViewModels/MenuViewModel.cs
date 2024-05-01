using Market.Models;

namespace Market.Areas.Tienda.ViewModels
{
    public class MenuViewModel:Base
    {
        public string? Nombre { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public string? Imagen { get; set; }
        
    }
}
