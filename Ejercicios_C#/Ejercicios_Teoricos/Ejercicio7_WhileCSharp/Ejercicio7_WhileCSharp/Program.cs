using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_WhileCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El WHILE lo que hace es repetir lo que se encuentra dentro de el hasta que la condicion no se cumpla mas, la condicion puede nunca cumplir por ende no entraria dentro

            int numero = 0;

            while(numero <= 10)
            {
                Console.WriteLine(numero);
                numero++;
            }
        }
    }
}
