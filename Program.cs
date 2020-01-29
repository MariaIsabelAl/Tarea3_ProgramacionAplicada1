using System;
using static Tarea3_ProgramacionAplicada1.Mascota;
using static Tarea3_ProgramacionAplicada1.Tienda;

namespace Tarea3_ProgramacionAplicada1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string respuesta = " ";

            Tienda tienda = new Tienda();
            Mascota mascota = new Mascota();
            Neumaticos neumaticos = new Neumaticos();
            ClassTienda classTienda = new ClassTienda();
            Estudiante estudiante = new Estudiante();
            Poligono poligono = new Poligono();
            Factorial factorial = new Factorial();

            Console.WriteLine("                                        MENU TAREA 3");
            Console.WriteLine("Capitulo 9");
            Console.WriteLine("1. Crear una estructura para los productos de una tienda.");
            Console.WriteLine("2. Crear estructuras enlazadas para la información de una mascota y su dueño.");
            Console.WriteLine("3. Crear una enumeración para los diferentes tipos de neumáticos.");

            Console.WriteLine("Capitulo 10");
            Console.WriteLine("4. Crear el diseño de una clase para llevar el inventario de una tienda.");
            Console.WriteLine("5. Crear una clase para llevar la información de los estudiantes de una escuela");
            Console.WriteLine("6. Crear una clase para polígonos con sobrecarga del constructor.Todos");

            Console.WriteLine("Capitulo 12");
            Console.WriteLine("7. Usar la depuración paso a paso para observar cómo cambia el valor de la variable en el programa del factorial.");
           
            do
            {
                Console.WriteLine("Elija la opcion del Menu Principal");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Capitulo 9, ejercicio 1");
                        Tiendas[] amigos = new Tiendas[5];
                        amigos[1].articulo = "Blusa"; 
                        amigos[1].cantidad = "5"; 
                        amigos[1].precio = 200;
                        Console.WriteLine(amigos[1].ToString());

                        break;
                    case 2:
                        Console.WriteLine("Capitulo 9, ejercicio 3");
                        Mascotas[] ami = new Mascotas[5];
                        ami[1].nombreDueño = "Maria";
                        ami[1].nombreMascota = "Brenda";
                        ami[1].raza= "Chiguagua";
                        Console.WriteLine(ami[1].ToString());
                        break;
                    case 3:
                        Console.WriteLine("Capitulo 9, ejercicio 4");
                        mascota.ToString();
                        break;
                    case 4:
                        Console.WriteLine("Capitulo 10, ejercicio 1");
                        Console.WriteLine("No se va a presentar nada porque no hay que impeimirlos ");
                        break;
                    case 5:
                        Console.WriteLine("Capitulo 10, ejercicio 2");
                        Console.WriteLine("No se va a presentar nada porque no hay que impeimirlos ");

                        break;
                    case 6:
                        Console.WriteLine("Capitulo 10, ejercicio 3,4,5");
                        poligono.ToString();
                        
                        break;
                    case 7:
                        Console.WriteLine("Capitulo 12, ejercicio 1");
                        factorial.calcularfactorial();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

               }
                Console.WriteLine(" ");
                Console.WriteLine("Deseas volver al Menu Principal (si / no) ?");
                respuesta = Console.ReadLine();
            } while (respuesta == "si");
        }
    }
}
