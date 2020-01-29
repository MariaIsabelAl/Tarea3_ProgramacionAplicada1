using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_ProgramacionAplicada1
{
    public partial class Mascota
    {
        public struct Mascotas
        {
            public string nombreDueño;
            public string nombreMascota;
            public string raza;

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre del dueno: { 0}, Nombre de la mascota: { 1}, Raza: { 2}", nombreDueño, nombreMascota, raza);
                return (sb.ToString());
            }
        }

    }
}
