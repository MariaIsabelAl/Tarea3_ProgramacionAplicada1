using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_ProgramacionAplicada1
{
    public partial class Tienda
    {
        public struct Tiendas
        {
            public string articulo;
            public decimal precio;
            public string cantidad;


            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Articulo: { 0}, Precio: { 1}, Cantidad: { 2}", articulo, precio, cantidad);
                return (sb.ToString());
            }


        }

          
    }
   
    
}
