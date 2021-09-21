
using System.Drawing;

namespace Ejercicio_Inmobiliaria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.txtAnos = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rbPiso = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.lblPlanta = new System.Windows.Forms.Label();
            this.lblVentanas = new System.Windows.Forms.Label();
            this.txtVentanas = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 235);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular Precio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(117, 12);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(138, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(117, 39);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(138, 20);
            this.txtMetros.TabIndex = 2;
            // 
            // txtAnos
            // 
            this.txtAnos.Location = new System.Drawing.Point(117, 66);
            this.txtAnos.Name = "txtAnos";
            this.txtAnos.Size = new System.Drawing.Size(138, 20);
            this.txtAnos.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(117, 93);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // rbPiso
            // 
            this.rbPiso.AutoSize = true;
            this.rbPiso.Location = new System.Drawing.Point(6, 19);
            this.rbPiso.Name = "rbPiso";
            this.rbPiso.Size = new System.Drawing.Size(45, 17);
            this.rbPiso.TabIndex = 5;
            this.rbPiso.TabStop = true;
            this.rbPiso.Text = "Piso";
            this.rbPiso.UseVisualStyleBackColor = true;
            this.rbPiso.CheckedChanged += new System.EventHandler(this.CambioTipoInmueble);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(6, 42);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 6;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.CambioTipoInmueble);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbLocal);
            this.grpTipo.Controls.Add(this.rbPiso);
            this.grpTipo.Location = new System.Drawing.Point(117, 119);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(138, 66);
            this.grpTipo.TabIndex = 7;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de Inmueble";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 15);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(12, 42);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(42, 13);
            this.lblMetros.TabIndex = 9;
            this.lblMetros.Text = "Metros²";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(12, 69);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(31, 13);
            this.lblAnos.TabIndex = 10;
            this.lblAnos.Text = "Años";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 96);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio Base";
            // 
            // txtPlanta
            // 
            this.txtPlanta.Location = new System.Drawing.Point(117, 192);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.Size = new System.Drawing.Size(138, 20);
            this.txtPlanta.TabIndex = 12;
            this.txtPlanta.Visible = false;
            // 
            // lblPlanta
            // 
            this.lblPlanta.AutoSize = true;
            this.lblPlanta.Location = new System.Drawing.Point(12, 195);
            this.lblPlanta.Name = "lblPlanta";
            this.lblPlanta.Size = new System.Drawing.Size(37, 13);
            this.lblPlanta.TabIndex = 13;
            this.lblPlanta.Text = "Planta";
            this.lblPlanta.Visible = false;
            // 
            // lblVentanas
            // 
            this.lblVentanas.AutoSize = true;
            this.lblVentanas.Location = new System.Drawing.Point(12, 195);
            this.lblVentanas.Name = "lblVentanas";
            this.lblVentanas.Size = new System.Drawing.Size(52, 13);
            this.lblVentanas.TabIndex = 14;
            this.lblVentanas.Text = "Ventanas";
            this.lblVentanas.Visible = false;
            // 
            // txtVentanas
            // 
            this.txtVentanas.Location = new System.Drawing.Point(117, 192);
            this.txtVentanas.Name = "txtVentanas";
            this.txtVentanas.Size = new System.Drawing.Size(138, 20);
            this.txtVentanas.TabIndex = 15;
            this.txtVentanas.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(10, 273);
            this.lblResultado.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 25);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 367);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtVentanas);
            this.Controls.Add(this.lblVentanas);
            this.Controls.Add(this.lblPlanta);
            this.Controls.Add(this.txtPlanta);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtAnos);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.TextBox txtAnos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rbPiso;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPlanta;
        private System.Windows.Forms.Label lblPlanta;
        private System.Windows.Forms.Label lblVentanas;
        private System.Windows.Forms.TextBox txtVentanas;
        private System.Windows.Forms.Label lblResultado;
    }
}

