using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Example
{
    public class Camion : ITransporte
    {
        public string entregar()
        {
            return "Se ha entregado el paquete por tierra.";
        }
    }
}
