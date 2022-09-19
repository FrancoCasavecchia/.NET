using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_DO_WHILE_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //El DO WHILE ejecuta una intruccion o intrucciones minetras que una exprecion booleana sea true, esto se evalua luego de cada instruccion en el while por ende se ejecuta 1 o mas veces.

            int number = 0;

            do
            {
                //Esto se va a ejecutar hasta que number sea 10
                Console.WriteLine(number);
                number++;
                Console.WriteLine("Se Sumo un numero");

            } while (number <= 15);     //aca podemos ver el while que se va a ir repitiendo la intruccion hasta que la condicion se cumpla

        }
    }
}
