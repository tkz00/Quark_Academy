using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion c = Conexion.getInstancia();

            //No se permite tener más de una instancia
            //Conexion c2 = new Conexion();

            c.conectar();

            c.desconectar();
        }
    }
}
