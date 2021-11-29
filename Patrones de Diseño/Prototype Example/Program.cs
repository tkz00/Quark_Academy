using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item("Furia Helada", Color.LightSkyBlue);

            Console.WriteLine(item.ToString());

            var Copy1 = item.ShallowCopy();

            Console.WriteLine(Copy1.ToString());

            Console.WriteLine(item == Copy1);

            var Copy2 = item.DeepCopy();

            Console.WriteLine(Copy2.ToString());

            Console.WriteLine(item == Copy2);

            //Change item values

            item.name = "Infierno rojo";
            item.color = Color.OrangeRed;
            item.type = "Montura";
            item.id = new IdInfo(666);

            //No se por qué los valores de referencia como el IdInfo y el Color no cambian con el ShallowCopy

            Console.WriteLine(item.ToString());
            Console.WriteLine(Copy1.ToString());
            Console.WriteLine(Copy2.ToString());
        }
    }
}
