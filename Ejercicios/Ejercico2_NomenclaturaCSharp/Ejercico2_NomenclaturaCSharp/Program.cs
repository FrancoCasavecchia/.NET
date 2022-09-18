using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico2_NomenclaturaCSharp
{
    internal class Program
    {
        //Variable privada, siempre tiene que empezar con " _ "
        private readonly string _varPrivada;
        static void Main(string[] args)
        {
            //Camel Case, empieza en minuscula y las siguientes palabras en mayusculas, se usa en variables locales y en mienbros privados. 
            var estoEsCamel = "Camel";

            //Pascal Case, se empeiza en mayusucla y las palabras siguientes siguen empezandon en mayusuclas, se usan en metodos, clases y tipos.
            var EstoEsPascal = "Pascal";
        }

        //Ejemplo Correcto de metodo con Pascal y con estandares correctos

        public int SumarDosNumeros(int Numero1, int Numero2)
        {
            var Resultado = Numero1 + Numero2;
            return Resultado;

        }

        //Ejemplo de estandares Incorrectos
        public int suma(int a,int b)
        {
            return a + b;
        }

    }
}
