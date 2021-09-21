using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CotizadorExpress.Controller;

namespace CotizadorExpress
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Una vez que carga el formulario instancio la tienda con sus datos y el vendedor
        /// y coloco la informacion de esos objeto en sus labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            TiendaController tienda = new TiendaController();

            var shop = tienda.InstantiateTienda();

            this.lblDireccionTienda.Text = shop.Address;
            this.lblNombreTienda.Text = shop.Name;

            VendedorController vendedor = new VendedorController();

            var seller = vendedor.InstantiateVendedor();

            this.lblCodigo.Text = seller.Code;
            this.lblNomApe.Text = seller.Name + " " + seller.Surname;
        }

        /// <summary>
        /// Cuando apreto el boton de "cotizar" capturo los valores de todos los elementos
        /// del formulario, creo los objetos dependiendo de el tipo elegido y los mando como parametro
        /// a la funcion de cotizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string calidad = rdPremium.Checked ? "Premium" : rdStandar.Checked ? "Standar" : "Standar";

            string sellerCode = lblCodigo.Text;
            CotizacionController cotizacion = new CotizacionController();
            string precio = txtPrecio.Text;
            string cantidad = txtCant.Text;

            if (rdCamisa.Checked)
            {

                CamisaController camisa = new CamisaController();

                bool mangaCorta = chkMangaCorta.Checked;
                bool cuelloMao = chkCuelloMao.Checked;

                var cami = camisa.CreateCamisa(mangaCorta, cuelloMao, calidad, precio, cantidad);

                double totalCoti = cotizacion.CreateCotizacion(sellerCode,cami, cantidad);

                if (totalCoti < 0)
                {
                    MessageBox.Show("No hay suficiente stock para cotizar", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    lblCotizacion.Text = totalCoti.ToString();
                    CheckStock();
                }


            }

            if (rdPantalon.Checked)
            {
                PantalonController pantalon = new PantalonController();

                bool chupines = chkChupin.Checked;

                var panta = pantalon.CreatePantalon(chupines,calidad, precio);

                double totalCotizacion = cotizacion.CreateCotizacion(sellerCode, panta, cantidad);

                if (totalCotizacion < 0)
                {
                    MessageBox.Show("No hay suficiente stock para cotizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblCotizacion.Text = totalCotizacion.ToString();
                    CheckStock();
                }

            }
        }

        /// <summary>
        /// Cada vez que cambio de tipo de prenda deshabilito las caracteristicas irrelevantes para ese item
        /// y habilito las que si importan
        /// </summary>
        private void rdPantalon_CheckedChanged(object sender, EventArgs e)
        {
            

            if (rdPantalon.Checked)
            {
                chkCuelloMao.Enabled = false;
                chkMangaCorta.Enabled = false;
                chkChupin.Enabled = true;
            }

            CheckStock();
        }


        /// <summary>
        /// Cada vez que cambio de tipo de prenda deshabilito las caracteristicas irrelevantes para ese item
        /// y habilito las que si importan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCamisa.Checked)
            {
                chkChupin.Enabled = false;
                chkCuelloMao.Enabled = true;
                chkMangaCorta.Enabled = true;
            }

            CheckStock();

        }

        /// <summary>
        /// Cuando apreto el boton que me muesta el historial lo voy a buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLinkHistorial_Click(object sender, EventArgs e)
        {
            CotizacionController cotizacion = new CotizacionController();

            MessageBox.Show(cotizacion.GetHistory());
        }


        private void chkChupin_CheckedChanged(object sender, EventArgs e)
        {
            CheckStock();
        }

        private void chkMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            CheckStock();
        }

        private void chkCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            CheckStock();
        }

        /// <summary>
        /// Checkeo el stock de la lista de stock de la tienda
        /// </summary>
        private void CheckStock()
        {
            bool isPantalon = rdPantalon.Checked;
            bool isChupin = chkChupin.Checked;
            bool isMangaCorta = chkMangaCorta.Checked;
            bool isMao = chkCuelloMao.Checked;

            TiendaController tienda = new TiendaController();
            var stock = tienda.CheckStock(isPantalon, isChupin, isMangaCorta, isMao);

            lblStock.Text = stock.ToString();
        }


    }
}
