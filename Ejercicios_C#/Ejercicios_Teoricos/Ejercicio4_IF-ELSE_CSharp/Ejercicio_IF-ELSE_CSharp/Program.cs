using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IF_ELSE_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IF Y ELSE, son condicionantes que al ejecutarse sucede una u otra cosa

            bool flag = true;
            int suma = 20 + 9;

            if (flag)
            {
                //En este caso FLAG al ser True pasara a esta seccion
                Console.WriteLine("Flag es TRUE");
            }
            else
            {
                //En el caso que FLAG sea false pasaria a esta seccion
                Console.WriteLine("Flag es FALSE");
            }

            if (suma == 29 && suma > 30)
            {
                //En este caso si se cumplen las condiciones pasaria a esta seccion
                Console.WriteLine("Se cumplen las condiciones");
            }
            else
            {
                //En el caso de que no se cumplan pasaria a esta seccion
                Console.WriteLine("No se cunplen las condiciones");
            }

        }
    }
}
