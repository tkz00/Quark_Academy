using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Inmobiliaria.Modelo
{
    class Local : Inmueble
    {
        private int numVentanas;

        private Local() { }

        internal protected Local(string Direccion, int MetrosCuadrados, int Anos, float PrecioBase, int NumVentanas) : base(Direccion, MetrosCuadrados, Anos, PrecioBase)
        {
            this.numVentanas = NumVentanas;
        }

        protected internal override float GetPrecio()
        {
            float auxPrecio = base.GetPrecio();

            if(this.metrosCuadrados > 50)
            {
                auxPrecio = auxPrecio * 101 / 100;
            }

            if(this.numVentanas <= 1)
            {
                auxPrecio = auxPrecio * 98 / 100;
            }
            else if(this.numVentanas > 4)
            {
                auxPrecio = auxPrecio * 102 / 100;
            }

            return auxPrecio;
        }
    }
}
