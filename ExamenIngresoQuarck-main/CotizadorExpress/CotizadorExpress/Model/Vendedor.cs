using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Model
{
    public class Vendedor
    {
        //Atributos
        private string name;
        private string surname;
        private string code;

        public static List<Cotizacion> cotizaciones = new List<Cotizacion>();

        //Propiedades
        public string Name 
        {
            get
            {
                return this.name;
            }

        }

        public string Surname 
        {
            get
            {
                return this.surname;
            }

        }

        public string Code 
        {
            get
            {
                return this.code;
            }
            
        }

        //Constructores
        public Vendedor()
        {
            this.name = "";
            this.surname = "";
            this.code = "FFF000";
        }

        public Vendedor(string name, string surname, string code)
        {
            this.name = name;
            this.surname = surname;
            this.code = code;
        }

    }
}
