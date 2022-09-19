using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_ConstantesCSharp
{
    internal class Program
    {
        //Constantes, la constante es el " const " que se agrega entre la entrada y el tipo de dato, y este sirve para que el valor que se ingresa sea constantes en todo el programa sin poder modificar ese valor
        public const string NOMBRE = "FRANCO";
        public const int NUMERO_PEDIDOS_MAXIMOS = 10;

        static void Main(string[] args)
        {
            //Ejemplo de uso de constante.

            for (int i = 0; i < 12; i++)
            {
                if (i < NUMERO_PEDIDOS_MAXIMOS)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }

        }
    }
}
