using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Switch_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //El swith tambien al igual que el if es un condicionante pero la diferencia es en su tipo de uso y en que el switch utiliza el "case" en vez del "else".

            int number = 5;

            switch (number)
            {
                case 5: Console.WriteLine("El numero es 5");
                    break;

                case 15:Console.WriteLine("No es 15");
                    break;

                case 78:Console.WriteLine("No es 79");
                    break;

                default: Console.WriteLine("No es ningun numero");
                    break;
            }

        }
    }
}
