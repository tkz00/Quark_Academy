using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Model
{
    public class Pantalon : Prenda
    {
        //Atributos
        private bool chupines;

        //Propiedades
        public bool Chupines
        {
            get
            {
                return this.chupines;
            }
        }

        //Constructores
        public Pantalon() { }

        public Pantalon(int stock, bool chupines) : base(stock)
        {
            this.chupines = chupines;
        }

        public Pantalon(string quality, int stock, bool chupines):base(quality,stock)
        {
            this.chupines = chupines;
        }

        public Pantalon(string quality, int stock, double precio, bool chupines) : this(quality, stock, chupines)
        {
            this.price = precio;
        }

        public Pantalon(string quality, double precio, bool chupines)
        {
            this.quality = quality;
            this.price = precio;
            this.chupines = chupines;
        }



    }
}
