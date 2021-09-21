using Ejercicio_Inmobiliaria.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Inmobiliaria.Presentador
{
    class InmueblePresenter
    {
        private Inmueble inmueble;
        private IView View;

        public InmueblePresenter(IView View)
        {
            this.View = View;
            Dictionary<string, string> Valores = View.GetInputData();
            string result = string.Empty;

            //Comprobación de inputs
            foreach (KeyValuePair<string, string> Valor in Valores)
            {
                //Verificar que el input no esté vacío
                if(string.IsNullOrEmpty(Valor.Value))
                {
                    result = $"El campo {Valor.Key} está vacío, lleneló antes de consultar el precio.";
                    break;
                }

                //Verificar que los inputs que deben ser enteros lo sean.
                if (Valor.Key == "Metros" || Valor.Key == "Anos" || Valor.Key == "Ventanas" || Valor.Key == "Planta")
                {
                    if (!Int32.TryParse(Valor.Value, out _))
                    {
                        result = $"El campo {Valor.Key} debería ser un número entero, completelo correctamente.";
                        break;
                    }
                }

                //Verificar que los inputs que deben ser flotantes lo sean.
                if (Valor.Key == "PrecioBase")
                {
                    if (!float.TryParse(Valor.Value, out _))
                    {
                        result = $"El campo {Valor.Key} debería ser un número decimal, completelo correctamente.";
                        break;
                    }
                }
            }

            if(string.IsNullOrEmpty(result))
            {
                Inmueble inmueble;
                if(Valores.ContainsKey("Ventanas"))
                {
                    inmueble = new Local(Valores["Direccion"], Int32.Parse(Valores["Metros"]), Int32.Parse(Valores["Anos"]), float.Parse(Valores["PrecioBase"]), Int32.Parse(Valores["Ventanas"]));
                }
                else
                {
                    inmueble = new Piso(Valores["Direccion"], Int32.Parse(Valores["Metros"]), Int32.Parse(Valores["Anos"]), float.Parse(Valores["PrecioBase"]), Int32.Parse(Valores["Planta"]));
                }

                result = $"El precio del inmueble es de {inmueble.GetPrecio():C2}";
            }

            this.View.MostrarResultado(result);
        }
    }
}
