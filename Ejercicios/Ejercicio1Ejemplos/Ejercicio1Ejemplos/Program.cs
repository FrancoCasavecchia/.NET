using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Ingrese su nombre");
                String nombre = Console.ReadLine();
                Console.ReadKey();

                Console.WriteLine("Ingrese un Pais");
                String pais = Console.ReadLine();
                Console.ReadKey();

                Console.WriteLine("Hola " + nombre + " Bienvenido a " + pais);
                Console.ReadKey();

        }
    }
}
