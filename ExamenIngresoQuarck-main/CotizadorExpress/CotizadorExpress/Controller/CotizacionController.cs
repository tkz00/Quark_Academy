using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorExpress.Model;

namespace CotizadorExpress.Controller
{
    public class CotizacionController
    {
        /// <summary>
        /// Creo una cotizacion, me fijo el tipo de dato que me llega, y lo meto en un switch
        /// dependiendo de las caracteristicas de las prendas manejo el total y una vez hecho eso
        /// checkeo si el stock me va a quedar en 0, si es asi retorno un -1
        /// </summary>
        /// <param name="sellerCode"></param>
        /// <param name="item"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public double CreateCotizacion(string sellerCode,object item,string unit)
        {
            var total = 0d;
            string type = item.GetType().Name;
            VendedorController vendedor = new VendedorController();
            TiendaController tienda = new TiendaController();
            var lastCoti = Vendedor.cotizaciones.LastOrDefault();
            var id = 0;

            if (lastCoti == null)
            {
                id = 1;
            }
            else
            {
                id = lastCoti.Id + 1;
            }

            switch (type)
            {
                case "Camisa":
                    Camisa camisa = (Camisa)item;
                    total += camisa.Price * int.Parse(unit);
                    if (camisa.MangaCorta)
                    {
                        total = total * .9;
                    }
                    if (camisa.Mao)
                    {
                        total = total * 1.03;
                    }
                    if (camisa.Quality == "Premium")
                    {
                        total = total * 1.3;
                    }

                    try
                    {
                        tienda.RestarStock(false, false, camisa.MangaCorta, camisa.Mao, int.Parse(unit));
                    }
                    catch (Exception)
                    {

                        return -1d;
                    }
                    

                    Cotizacion cotizacionCamisa = new Cotizacion(id, sellerCode, camisa, int.Parse(unit), total);

                    vendedor.AddCotizacion(cotizacionCamisa);
                    break;

                case "Pantalon":
                    Pantalon pantalon = (Pantalon)item;
                    total += pantalon.Price * int.Parse(unit);
                    if (pantalon.Chupines)
                    {
                        total = total * .88;
                    }
                    if (pantalon.Quality == "Premium")
                    {
                        total = total * 1.3;
                    }

                    try
                    {
                        tienda.RestarStock(true, pantalon.Chupines, false, false, int.Parse(unit));
                    }
                    catch (Exception)
                    {

                        return -1d;
                    }

                    Cotizacion cotizacionPantalon = new Cotizacion(id, sellerCode, pantalon, int.Parse(unit), total);
                    vendedor.AddCotizacion(cotizacionPantalon);
                    break;
                default:
                    break;
            }

            return total;
        }

        /// <summary>
        /// Recorro la lista de cotizaciones del vendedor y armo un string con cada una de ellas
        /// </summary>
        /// <returns></returns>
        public string GetHistory()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cotizaciones: ");
            foreach (var item in Vendedor.cotizaciones)
            {
                sb.AppendLine($"Numero:{item.Id}");
                sb.AppendLine($"Fecha:{item.Created}");
                sb.AppendLine($"Total:{item.Result}");
                sb.AppendLine($"Vendedor:{item.SellerCode}");
                sb.AppendLine("--------------");
            }

            return sb.ToString();
        }
    }
}
