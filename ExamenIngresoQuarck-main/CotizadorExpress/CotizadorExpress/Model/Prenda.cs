using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Model
{
    public class Prenda
    {
        //Atributos
        protected string quality;
        protected int stock;
        protected double price;

        //Propiedades
        public string Quality
        {
            get
            {
                return this.quality;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
        }

        //Constructores
        public Prenda()
        {

        }

        public Prenda(int stock)
        {
            this.stock = stock;
        }

        public Prenda(string quality, int stock/*, double price*/):this(stock)
        {
            this.quality = quality;
        }

        public Prenda(string quality, int stock, double price):this(quality,stock)
        {
            this.price = price;
        }

    }
}
