using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_ArraysYMatricesCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Simples

            int[] arrayEntero = new int[5];
            int[] arrayEnteroConNumeros = { 1, 5, 6, 8 };

            //Array 2D

            int[,] array2D = new int[2, 3];
            int[,] array2DConNumeros = { { 2, 5 }, { 3, 6 } };

            //Array Escalonado

            int[][] arrayEscalonado = new int[3][];
            arrayEscalonado[0] = new int[4] {2,5,6,9 };
            arrayEscalonado[1] = new int[2] { 1, 10 };


            //Como mostrar los arrays

            foreach (var numArray in arrayEnteroConNumeros)
            {
                Console.WriteLine(numArray);
            }

            Console.WriteLine(" ");

            foreach (var numArray2 in array2DConNumeros)
            {
                Console.WriteLine(numArray2);
            }

            Console.WriteLine(" ");

            foreach (var numArray3 in arrayEscalonado[0])
            {
                Console.WriteLine(numArray3);
            }
        }
    }
}
