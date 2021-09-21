using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloVistaPresentador_Example.Presentador;

namespace ModeloVistaPresentador_Example
{
    public partial class Form1 : Form, IView
    {

        DatePresenter datePresenter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            datePresenter = new DatePresenter(this);
        }

        void IView.DisplayResult(string result)
        {
            lblResult.Text = result;
        }

        string IView.GetInputDate()
        {
            return txtDate.Text;
        }
    }
}
