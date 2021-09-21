using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress.Model
{
    public class Camisa : Prenda
    {
        //Atributos
        private bool mangaCorta;
        private bool mao;

        //Propiedades
        public bool MangaCorta
        {
            get
            {
                return this.mangaCorta;
            }

        }

        public bool Mao
        {
            get
            {
                return this.mao;
            }
        }

        //Constructores
        public Camisa()
        {
        }

        public Camisa(int stock, bool mangaCorta, bool mao) : base(stock)
        {
            this.mangaCorta = mangaCorta;
            this.mao = mao;
        }

        public Camisa(string quality, int stock, bool mangaCorta, bool mao):base(quality,stock)
        {
            this.mangaCorta = mangaCorta;
            this.mao = mao;
        }

        public Camisa(string quality, int stock, bool mangaCorta, bool mao, double precio) : base(quality, stock, precio)
        {
            this.mangaCorta = mangaCorta;
            this.mao = mao;
        }


    }
}
