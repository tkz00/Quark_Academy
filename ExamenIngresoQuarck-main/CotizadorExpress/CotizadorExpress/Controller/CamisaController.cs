using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorExpress.Model;

namespace CotizadorExpress.Controller
{
    public class CamisaController
    {
        /// <summary>
        /// Creo un objeto de tipo camisa y lo devuelvo
        /// </summary>
        /// <param name="mangaCorta"></param>
        /// <param name="cuelloMao"></param>
        /// <param name="calidad"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public Camisa CreateCamisa(bool mangaCorta, bool cuelloMao, string calidad, string precio, string cantidad = "0")
        {
            int cantidadNew = int.Parse(cantidad);
            double precioNew = double.Parse(precio);

            Camisa camisa = new Camisa(calidad,cantidadNew,mangaCorta,cuelloMao, precioNew);

            return camisa;

        }
    }
}
