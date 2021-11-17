using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Example
{
    public class Conexion
    {
        private static Conexion instancia;

        private Conexion() { }

        public static Conexion getInstancia()
        {
            if(instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public void conectar()
        {
            Console.WriteLine("Se conectó a la BD con éxito.");
        }

        public void desconectar()
        {
            Console.WriteLine("Se desconectó de la BD con éxito.");
        }
    }
}
