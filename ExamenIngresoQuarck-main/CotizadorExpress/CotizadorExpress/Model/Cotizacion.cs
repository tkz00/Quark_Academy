using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Model
{
    public class Cotizacion
    {
        //Atributos
        private int id;
        private DateTime created;
        private string sellerCode;
        private Prenda item;
        private int unit;
        private double result;

        //Propiedades
        public int Id 
        {
            get
            {
                return this.id;
            }
        }

        public DateTime Created 
        {
            get
            {
                return this.created;
            }
        }

        public string SellerCode 
        {
            get
            {
                return this.sellerCode;
            }
        }

        public Prenda Item 
        {
            get
            {
                return this.item;
            }
        }

        public int Unit 
        {
            get
            {
                return this.unit;
            }
        }

        public double Result 
        {
            get
            {
                return this.result;
            }
        }

        //Constructores
        public Cotizacion(int id, string sellerCode, Prenda item, int unit, double result)
        {
            this.id = id;
            this.created = DateTime.Now;
            this.sellerCode = sellerCode;
            this.item = item;
            this.unit = unit;
            this.result = result;

        }
    }
}
