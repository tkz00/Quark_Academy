using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Model
{
    public class Tienda
    {
        //Atributos
        private string name;
        private string address;
        public static List<Prenda> items;

        //Propiedades
        public string Name 
        { 
            get 
            {
                return this.name;
            } 
        }

        public string Address 
        {
            get
            {
                return this.address;
            }
        }

        //Constructores
        public Tienda()
        {

        }

        public Tienda(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
