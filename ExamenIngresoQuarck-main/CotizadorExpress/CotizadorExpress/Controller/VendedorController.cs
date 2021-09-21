using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorExpress.Model;

namespace CotizadorExpress.Controller
{
    public class VendedorController
    {
        /// <summary>
        /// Instancio un vendedor con datos hardcodeados
        /// </summary>
        /// <returns></returns>
        public Vendedor InstantiateVendedor()
        {
            Vendedor vendedor = new Vendedor("Franco", "Delocca", "FD2305");

            return vendedor;
        }

        /// <summary>
        /// Añado un objeto de tipo cotizacion a la lista de cotizaciones del vendedor
        /// </summary>
        /// <param name="cotizacionPantalon"></param>
        public void AddCotizacion(Cotizacion cotizacionPantalon)
        {
            Vendedor.cotizaciones.Add(cotizacionPantalon);
        }
    }
}
