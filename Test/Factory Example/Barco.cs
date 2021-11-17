using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Example
{
    public class Barco : ITransporte
    {
        public string entregar()
        {
            return "Se ha entregado el paquete por agua.";
        }
    }
}
