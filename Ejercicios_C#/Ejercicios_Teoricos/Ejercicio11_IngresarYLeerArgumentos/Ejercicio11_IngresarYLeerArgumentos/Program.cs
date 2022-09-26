using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11_IngresarYLeerArgumentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay " + args.Length + " Elementos");

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
