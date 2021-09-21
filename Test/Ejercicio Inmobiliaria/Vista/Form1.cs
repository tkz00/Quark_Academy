using Ejercicio_Inmobiliaria.Presentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Inmobiliaria
{
    public partial class Form1 : Form, IView
    {
        InmueblePresenter presenter = null;
        public Form1()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> GetInputData()
        {
            Dictionary<string, string> Valores = new Dictionary<string, string>()
            {
                {"Direccion", this.txtDireccion.Text },
                {"Metros", this.txtMetros.Text },
                {"Anos", this.txtAnos.Text },
                {"PrecioBase", this.txtPrecio.Text },
            };

            Valores.Add((this.rbLocal.Checked ? "Ventanas" : "Planta"), (this.rbLocal.Checked ? this.txtVentanas.Text : this.txtPlanta.Text));

            return Valores;
        }

        public void MostrarResultado(string resultado)
        {
            this.lblResultado.Text = resultado;
            this.lblResultado.Visible = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.presenter = new InmueblePresenter(this);
        }

        private void CambioTipoInmueble(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if(rb.Checked)
            {
                if(rb.Text == "Piso")
                {
                    this.lblPlanta.Visible = true;
                    this.txtPlanta.Visible = true;
                    this.lblVentanas.Visible = false;
                    this.txtVentanas.Visible = false;
                }
                else if(rb.Text == "Local")
                {
                    this.lblPlanta.Visible = false;
                    this.txtPlanta.Visible = false;
                    this.lblVentanas.Visible = true;
                    this.txtVentanas.Visible = true;
                }
            }
        }
    }
}
