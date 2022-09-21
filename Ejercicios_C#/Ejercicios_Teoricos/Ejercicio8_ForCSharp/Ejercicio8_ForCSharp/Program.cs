using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_ForCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El for ejecuta una seccion o varias secciones mientras una especificacion es TRUE.

            int numero = 50;

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(i);
                if (i >= 15)
                {
                    break;
                } 
            }

        }
    }
}
