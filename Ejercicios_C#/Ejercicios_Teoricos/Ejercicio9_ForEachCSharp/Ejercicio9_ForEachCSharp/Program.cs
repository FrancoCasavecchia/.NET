using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_ForEachCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaDeJuegos = new List<Juego>();

            var juego1 = new Juego()
            {
                Name = "XDDX",
                Description = "Muy Bueno",
                Costo = 35
            };

            var juego2 = new Juego()
            {
                Name = "Lol",
                Description = "Muyy MALO",
                Costo = 10
            };

            listaDeJuegos.Add(juego1);
            listaDeJuegos.Add(juego2);

            foreach (var juego in listaDeJuegos)
            {
                Console.WriteLine(juego.Name + juego.Description + juego.Costo);
            }
        }
    }
}

public class Juego
{
    public string Name { get; set; }
    public string Description { get; set; } 
    public int Costo {get; set; }   
}