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
            FabricaTransporte fabricaTransporte;
            Console.WriteLine("Ingrese \"Tierra\" si desea envíar el paquete con un camión o \"Agua\" si desea enviarlo a través de un barco");
            string opcion = Console.ReadLine();

            if(opcion == "Tierra")
            {
                fabricaTransporte = new FabricaCamion();
            }
            else if(opcion == "Agua")
            {
                fabricaTransporte = new FabricaBarco();
            }
            else
            {
                throw new Exception("No se eligió ninguna de las opciones especificadas.");
            }

            ITransporte transporte = fabricaTransporte.GetTransporte();

            Console.WriteLine(transporte.entregar());
        }
    }
}
