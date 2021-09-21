using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Inmobiliaria
{
    abstract class Inmueble
    {
        private string direccion;
        protected internal int metrosCuadrados;
        private int anos;
        private float precioBase;

        protected internal Inmueble() { }

        protected internal Inmueble(string Direccion, int MetrosCuadrados, int Anos, float PrecioBase) : this()
        {
            this.direccion = Direccion;
            this.metrosCuadrados = MetrosCuadrados;
            this.anos = Anos;
            this.precioBase = PrecioBase;
        }

        protected internal virtual float GetPrecio()
        {
            if(this.anos <= 0)
            {
                return this.precioBase;
            }
            else if(this.anos < 15)
            {
                return this.precioBase * 99 / 100;
            }

            return this.precioBase * 98 / 100;
        }

    }
}
