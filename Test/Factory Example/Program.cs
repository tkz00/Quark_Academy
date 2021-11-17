using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaTransporte transporte;
            Console.WriteLine("Ingrese \"Tierra\" si desea envíar el paquete con un camión o \"Agua\" si desea enviarlo a través de un barco");
            string opcion = Console.ReadLine();

            if(opcion == "Tierra")
            {
                transporte = new FabricaCamion();
            }
            else if(opcion == "Agua")
            {
                transporte = new FabricaBarco();
            }
            else
            {
                throw new Exception("No se eligió ninguna de las opciones especificadas.");
            }

            transporte.Entregar();
        }
    }
}
