using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorExpress.Model;

namespace CotizadorExpress.Controller
{
    public class PantalonController
    {
        /// <summary>
        /// Creo un objeto de tipo pantalon y lo devuelvo
        /// </summary>
        /// <param name="chupin"></param>
        /// <param name="calidad"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        public Pantalon CreatePantalon(bool chupin, string calidad, string precio)
        {
            //int cantidadNew = int.Parse(cantidad);
            double precioNew = double.Parse(precio);

            Pantalon pantalon = new Pantalon(calidad, precioNew, chupin);

            return pantalon;

        }
    }
}
