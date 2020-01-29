using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_ProgramacionAplicada1
{
    class Poligono
    {
        public int cantidadLados { get; set; }
        public float longitud { get; set; }
        public float apotema { get; set; }

        public Poligono()
        {
        }

        public override string ToString()
        {
            String mostrar = "";
            mostrar += "Cantidad de lados: " + longitud.ToString() + " \nLongitud de cada lado:  " +
            cantidadLados.ToString() + "\nApotema " + apotema.ToString();

            return mostrar;
        }
    }
}
