using Market.Areas.Tienda.Interfaces;
using Market.Areas.Tienda.ViewModels;
using Microsoft.AspNetCore.Mvc;






namespace Market.Areas.Tienda.Services
{  
    
    public class ProductosServicices: IProductos
    {
 
        public List<ProductosViewModel> productos()
        {
            var productos = new List<ProductosViewModel>()
{
    new ProductosViewModel
    {
        Nombre = "Camiseta de algodón",
        Descripcion = "Camiseta de algodón suave y cómoda, perfecta para el uso diario.",
        Id = 1,
        Precio = 25.99m,
        NombreCategoria = "Ropa",
        IdCategoria = 1
       
    },
    new ProductosViewModel
    {
        Nombre = "Zapatillas deportivas",
        Descripcion = "Zapatillas deportivas de alta calidad con suela acolchada para mayor comodidad.",
        Id = 2,
        Precio = 59.99m,
        NombreCategoria = "Ropa",
        IdCategoria = 1
        
    },
    new ProductosViewModel
    {
        Nombre = "Teléfono inteligente",
        Descripcion = "Teléfono inteligente de última generación con pantalla HD y cámara de alta resolución.",
        Id = 3,
        Precio = 699.99m,
        NombreCategoria = "Electrónica",
        IdCategoria = 2

    },
      new ProductosViewModel
    {
        Nombre = "Portátil Dell Inspiron 15",
        Descripcion = "Portátil Dell Inspiron 15 con pantalla de 15.6 pulgadas, procesador Intel Core i5, 8 GB de RAM y 512 GB de SSD.",
        Id = 4,
        Precio = 849.99m,
        NombreCategoria = "Electrónica",
        IdCategoria = 2
    },
    new ProductosViewModel
    {
        Nombre = "Libro 'Cien años de soledad'",
        Descripcion = "Novela del escritor colombiano Gabriel García Márquez. Una obra maestra de la literatura latinoamericana.",
        Id = 5,
        Precio = 19.99m,
        NombreCategoria = "Libros",
        IdCategoria = 3
    },
    new ProductosViewModel
    {
        Nombre = "Cámara digital Canon EOS Rebel T7",
        Descripcion = "Cámara digital DSLR con sensor CMOS de 24.1 megapíxeles, pantalla LCD de 3 pulgadas y grabación de video Full HD.",
        Id = 6,
        Precio = 499,
        NombreCategoria = "Electrónica",
        IdCategoria = 2
    },
    new ProductosViewModel
    {
        Nombre = "Silla de oficina ergonómica",
        Descripcion = "Silla de oficina ergonómica con soporte lumbar ajustable y reposabrazos acolchados.",
        Id = 7,
        Precio = 129,
        NombreCategoria = "Muebles",
        IdCategoria = 4
    }
};


            return productos;
        }

        public List<ProductosViewModel> GetProductos()
        {
            var Producto = productos();

            return Producto;

        }
        public List<ProductosViewModel> GetProductoxCategorias(int IdCategoria)
        {
            
            var Producto=productos().Where(x => x.IdCategoria == IdCategoria).ToList();
            return Producto;
        }
    }

   
}
