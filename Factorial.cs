using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_ProgramacionAplicada1
{
    class Factorial
    {
   
        public void calcularfactorial()
        {
            
                int numero;

                numero = Convert.ToInt32(Console.ReadLine());

                for (int i = numero - 1; i > 1; i--)
                {
                    numero = numero * i;
                    Console.WriteLine("{0}\n", numero);
                }
                Console.WriteLine("\nEl factorial es: {0}", numero);
                 
        }

 
    }
}
