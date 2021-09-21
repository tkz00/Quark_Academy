using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Inmobiliaria.Modelo
{
    class Piso : Inmueble
    {
        private int planta;

        private Piso() { }

        internal protected Piso(string Direccion, int MetrosCuadrados, int Anos, float PrecioBase, int Planta) : base(Direccion, MetrosCuadrados, Anos, PrecioBase)
        {
            this.planta = Planta;
        }

        protected internal override float GetPrecio()
        {
            if (this.planta >= 3)
            {
                return base.GetPrecio() * 103 / 100;
            }

            return base.GetPrecio();
        }
    }
}
