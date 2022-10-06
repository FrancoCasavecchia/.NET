using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace EjercicioPractico1_CSharp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores.
            // Mostrar por consola.

            WriteLine("Ejercicio 1");
            int var1 = 5;
            int var2 = 5;
            int var3 = 7;

            int resultado = var1 + var2 + var3;
            WriteLine(resultado);

            WriteLine("");

            //Pedir dos números al usuario por teclado y decir que número es el mayor.
            WriteLine("Ejercicio 2");

            WriteLine("Ingrese un numero");
            int numero1 = ToInt32(ReadLine());

            WriteLine("Ingrese otro numero");
            int numero2 = ToInt32(ReadLine());

            if(numero1 < numero2)
            {
                WriteLine("El segundo Numero es mayor");
            }
            else
            {
                WriteLine("El primer Numero es mayor");
            }

            WriteLine("");

            //Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo
            WriteLine("Ejercicio 3");

            String[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };

            WriteLine("Ingrese un Dia de la semana");
            String dia = ReadLine();

            for(int i = 0; i < semana.Length; i++)
            {
                if (dia == semana[i])
                {
                    WriteLine("Es Dia de semana");
                    break;
                }
                else
                {
                    WriteLine("Es Fin de Semana");
                    break;
                }
            }  

            WriteLine("");

            //Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta)
            //si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado).
            WriteLine("Ejercicio 4");

            WriteLine("Ingrese el precio del Producto");
            int precio = ToInt32(ReadLine());

            WriteLine("Ingrese el metodo de pago, Tarjeta o Efectivo?");
            string metodo = ReadLine();

            if (metodo == "Tarjeta")
            {
                WriteLine("Ingrese el Numero de Cuenta");
                int cuenta = ToInt32(ReadLine());
                WriteLine("El pago es de " + precio + " Y se paga en " + metodo + " Y el numero de cuenta es "+cuenta);
            }
            else
            {
                WriteLine("El pago es de " + precio + " Y se paga en " + metodo);
            }
            
            WriteLine("");

            //Recorre los números del 1 al 100. Usa un bucle for.
            WriteLine("Ejercicio 5");

            

            for (int i = 0; i <= 100; i++)
            {
                WriteLine("El Numero es " + i);
                WriteLine("-----------------------------");
            }

            WriteLine();

            //Recorre los números del 1 al 100. Usa un bucle while.
            WriteLine("Ejercicio 6");
            int y = 0;

            while (y != 100)    
            {
                WriteLine("El numero es " + y);
                y++;
                WriteLine("-----------------------------");
            }

            WriteLine("");

            //Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
            WriteLine("Ejercicio 7");
            for (int x = 0; x <= 100; x++)
            {
                if ((x % 2 ) == 0)
                {
                    WriteLine(x + " Es Par");
                    WriteLine("-----------------------------");
                }
            }

                WriteLine("");

            //Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.
            WriteLine("Ejercicio 8");
            for (int z = 0; z <= 100; z++)
            {
                if ((z % 2) == 0 || (z % 3) == 0)
                {
                    WriteLine(z + " Es Par o divisible por 3");
                    WriteLine("-----------------------------");
                }
            }

            WriteLine("");

            //Crea un array e inserta los números pares del 1 al 100 en ese array.
            WriteLine("Ejercicio 9");

            int[] arrayPares = new int[101];

            for (int p = 1; p <= 100 ; p++)
            {
                if ((p % 2) == 0)
                {
                    arrayPares[p] = p;
                    WriteLine("Numero en el array " + arrayPares[p]);
                    WriteLine("-----------------------------");
                }

            }

            WriteLine(" ");

            //Pide 10 números por consola, muestra el resultado por consola de sumar los
            //pares y restarle los impares.
            WriteLine("Ejercicio 10");

         


            byte CAN, K;
            int NUM;
            int SUM = 0;
            string linea;

            Console.Write("LÍMITE:"); 
            linea = ReadLine();
            CAN = byte.Parse(linea);

            for (K = 1; K <= CAN; K++)
            {
                Write("DIGITE UN NÚMERO:"); 
                linea = ReadLine();
                NUM = int.Parse(linea);
                SUM += NUM;
            }
            WriteLine("SUMA TOTAL ES : " + SUM);
            Write("Pulse una Tecla:");  ReadLine();




            WriteLine(" ");
            //11- Crea un programa, que pida un número del 1 al 7,
            //devuelva el día de la semana ,teniendo en cuenta que el 1 es Lunes,
            //hacer con un switch.
            WriteLine("Ejercicio 11");

            WriteLine("Ingrese un numero del 1 al 7 y te devolvera el dia de la semana correspondiente");
            int numeroSem = ToInt32(ReadLine());

            switch (numeroSem)
            {
                case 1:WriteLine("Lunes");
                    break;

                case 2: WriteLine("Martes");
                    break ;

                case 3: WriteLine("Miercoles");
                    break;

                case 4: WriteLine("Jueves");
                    break;

                case 5: WriteLine("Viernes");
                    break;

                case 6: WriteLine("Sabado");
                    break;

                case 7: WriteLine("Domingo");       
                    break;

                default: WriteLine("No se ingreso ningun numero");
                    break;
            }

            WriteLine("");

            //12- Crea un programa que pida por consola un numero del 1 al 1000
            //(validara que el numero introducido es correcto) y
            //sume todos los números del 1 al numero introducido,
            //mostrando por consola el numero de la suma y la media.

            WriteLine("Ejercicio 12");

            WriteLine("Ingrese un numero del 1 al 1000");
            int numUnoMil = ToInt32(ReadLine());
            int numFinal = 0;

            if(numUnoMil <=1000 && numUnoMil >= 1)
            {
                while (numUnoMil != 1000)
                {
                    int numEjemplo = 0;
                    numFinal = numEjemplo + numEjemplo;
                    numEjemplo++;
                }

                WriteLine("La suma de los numeros desde el 1 al seleccionado es de " + numFinal);
            }
            else
            {
                WriteLine("El numero ingresado es incorrecto");
            }

            WriteLine("");

            //13 Comprobar si un numero introducido por consola es primo
            WriteLine("Ejercicio 13");

            int sw, resi;
            int xx = 2;
            sw = 0;
            WriteLine("NUMERO PRIMO");
            WriteLine();
            Write("Ingrese el numero:");
            int lineaa =  ToInt32(ReadLine());

            while (xx < lineaa && sw == 0)
            {
                resi = lineaa % xx;
                if (resi == 0)
                {
                    sw = 1;
                }
                else
                {
                    xx = xx + 1;
                }
            }
            if (sw == 0)
            {
                 WriteLine();
                 WriteLine("El numero es PRIMO");
            }
            else
            {
                 WriteLine();
                 WriteLine("El numero no es PRIMO");
            }
             ReadKey();

            WriteLine();
            WriteLine("FIN");

        }
    }
}
