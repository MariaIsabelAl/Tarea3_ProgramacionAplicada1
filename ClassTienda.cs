using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_ProgramacionAplicada1
{
    class ClassTienda
    {
        public string articulo { get; set; }
        public string descripcion { get; set; }
        public decimal precioVenta { get; set; }
        public int cantidad { get; set; }
        public decimal precioCompra { get; set; }

        public ClassTienda()
        {
            this.articulo = articulo;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
            this.cantidad = cantidad;
            this.precioCompra = precioCompra;
        }
    }
}
