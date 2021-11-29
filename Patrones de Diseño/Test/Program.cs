using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public delegate bool Comparacion(char caracter);

    class Program
    {
        public static String Filtrar(string palabra, Comparacion compara)
        {
            string aux = "";

            foreach (char caracter in palabra)
            {
                if (compara(caracter))
                {
                    aux += caracter;
                }
            }

            return aux;
        }

        static void Main(string[] args)
        {
            string test = "Me3 g7US89t4a6 113La p1a84pu6654Sa";

            Console.WriteLine("Solo las vocales de la palabra: ");
            Console.WriteLine(Program.Filtrar(test, (x) => "aeiouAEIOU".IndexOf(x) >= 0));

            Console.WriteLine("Solo los números de la palabra: ");
            Console.WriteLine(Program.Filtrar(test, (x) => Char.IsDigit(x)));

            Console.WriteLine("Solo las mayúsculas de la palabra: ");
            Console.WriteLine(Program.Filtrar(test, (x) => Char.IsUpper(x)));

            Console.WriteLine("Solo los caracteres y números de la palabra: ");
            Console.WriteLine(Program.Filtrar(test, (x) => Char.IsLower(x)));
        }
    }
}
