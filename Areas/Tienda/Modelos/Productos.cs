﻿using Market.Models;

namespace Market.Areas.Tienda.Modelos
{
    public class Productos : Base 
    {

        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Imagen { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoria { get; set; }
        public virtual Categorias? Categorias { get; set; }

    }
}
