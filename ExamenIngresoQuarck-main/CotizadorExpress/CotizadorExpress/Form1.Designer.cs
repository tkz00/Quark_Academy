
namespace CotizadorExpress
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNomApe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLinkHistorial = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCamisa = new System.Windows.Forms.RadioButton();
            this.rdPantalon = new System.Windows.Forms.RadioButton();
            this.chkMangaCorta = new System.Windows.Forms.CheckBox();
            this.chkCuelloMao = new System.Windows.Forms.CheckBox();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdStandar = new System.Windows.Forms.RadioButton();
            this.rdPremium = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 101);
            this.panel1.TabIndex = 1;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblNombreTienda.Location = new System.Drawing.Point(12, 110);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(136, 20);
            this.lblNombreTienda.TabIndex = 2;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblDireccionTienda.Location = new System.Drawing.Point(380, 110);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(199, 20);
            this.lblDireccionTienda.TabIndex = 3;
            this.lblDireccionTienda.Text = "Dirección de la Tienda";
            this.lblDireccionTienda.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNomApe
            // 
            this.lblNomApe.AutoSize = true;
            this.lblNomApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomApe.Location = new System.Drawing.Point(12, 147);
            this.lblNomApe.Name = "lblNomApe";
            this.lblNomApe.Size = new System.Drawing.Size(221, 20);
            this.lblNomApe.TabIndex = 4;
            this.lblNomApe.Text = "Nombre y Apellido Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(384, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 5;
            // 
            // lblLinkHistorial
            // 
            this.lblLinkHistorial.AutoSize = true;
            this.lblLinkHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLinkHistorial.LinkColor = System.Drawing.Color.DarkViolet;
            this.lblLinkHistorial.Location = new System.Drawing.Point(384, 147);
            this.lblLinkHistorial.Name = "lblLinkHistorial";
            this.lblLinkHistorial.Size = new System.Drawing.Size(174, 20);
            this.lblLinkHistorial.TabIndex = 6;
            this.lblLinkHistorial.TabStop = true;
            this.lblLinkHistorial.Text = "Historial Cotizaciones";
            this.lblLinkHistorial.Click += new System.EventHandler(this.lblLinkHistorial_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChupin);
            this.groupBox1.Controls.Add(this.chkCuelloMao);
            this.groupBox1.Controls.Add(this.chkMangaCorta);
            this.groupBox1.Controls.Add(this.rdPantalon);
            this.groupBox1.Controls.Add(this.rdCamisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // rdCamisa
            // 
            this.rdCamisa.AutoSize = true;
            this.rdCamisa.Location = new System.Drawing.Point(18, 38);
            this.rdCamisa.Name = "rdCamisa";
            this.rdCamisa.Size = new System.Drawing.Size(84, 24);
            this.rdCamisa.TabIndex = 0;
            this.rdCamisa.TabStop = true;
            this.rdCamisa.Text = "Camisa";
            this.rdCamisa.UseVisualStyleBackColor = true;
            this.rdCamisa.CheckedChanged += new System.EventHandler(this.rdCamisa_CheckedChanged);
            // 
            // rdPantalon
            // 
            this.rdPantalon.AutoSize = true;
            this.rdPantalon.Location = new System.Drawing.Point(18, 94);
            this.rdPantalon.Name = "rdPantalon";
            this.rdPantalon.Size = new System.Drawing.Size(92, 24);
            this.rdPantalon.TabIndex = 1;
            this.rdPantalon.TabStop = true;
            this.rdPantalon.Text = "Pantalón";
            this.rdPantalon.UseVisualStyleBackColor = true;
            this.rdPantalon.CheckedChanged += new System.EventHandler(this.rdPantalon_CheckedChanged);
            // 
            // chkMangaCorta
            // 
            this.chkMangaCorta.AutoSize = true;
            this.chkMangaCorta.Location = new System.Drawing.Point(171, 38);
            this.chkMangaCorta.Name = "chkMangaCorta";
            this.chkMangaCorta.Size = new System.Drawing.Size(121, 24);
            this.chkMangaCorta.TabIndex = 2;
            this.chkMangaCorta.Text = "Manga corta";
            this.chkMangaCorta.UseVisualStyleBackColor = true;
            this.chkMangaCorta.CheckedChanged += new System.EventHandler(this.chkMangaCorta_CheckedChanged);
            // 
            // chkCuelloMao
            // 
            this.chkCuelloMao.AutoSize = true;
            this.chkCuelloMao.Location = new System.Drawing.Point(368, 38);
            this.chkCuelloMao.Name = "chkCuelloMao";
            this.chkCuelloMao.Size = new System.Drawing.Size(112, 24);
            this.chkCuelloMao.TabIndex = 3;
            this.chkCuelloMao.Text = "Cuello mao";
            this.chkCuelloMao.UseVisualStyleBackColor = true;
            this.chkCuelloMao.CheckedChanged += new System.EventHandler(this.chkCuelloMao_CheckedChanged);
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Location = new System.Drawing.Point(171, 94);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(80, 24);
            this.chkChupin.TabIndex = 4;
            this.chkChupin.Text = "Chupin";
            this.chkChupin.UseVisualStyleBackColor = true;
            this.chkChupin.CheckedChanged += new System.EventHandler(this.chkChupin_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 56);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unidades de stock disponibles: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblStock.Location = new System.Drawing.Point(255, 20);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(63, 20);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "______";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdPremium);
            this.groupBox3.Controls.Add(this.rdStandar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox3.Location = new System.Drawing.Point(16, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 81);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de Prenda";
            // 
            // rdStandar
            // 
            this.rdStandar.AutoSize = true;
            this.rdStandar.Location = new System.Drawing.Point(18, 37);
            this.rdStandar.Name = "rdStandar";
            this.rdStandar.Size = new System.Drawing.Size(85, 24);
            this.rdStandar.TabIndex = 0;
            this.rdStandar.TabStop = true;
            this.rdStandar.Text = "Standar";
            this.rdStandar.UseVisualStyleBackColor = true;
            // 
            // rdPremium
            // 
            this.rdPremium.AutoSize = true;
            this.rdPremium.Location = new System.Drawing.Point(146, 37);
            this.rdPremium.Name = "rdPremium";
            this.rdPremium.Size = new System.Drawing.Size(94, 24);
            this.rdPremium.TabIndex = 1;
            this.rdPremium.TabStop = true;
            this.rdPremium.Text = "Premium";
            this.rdPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtCant);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtPrecio);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox4.Location = new System.Drawing.Point(314, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 80);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio unitario y Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(35, 32);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(62, 26);
            this.txtPrecio.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "$";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(210, 32);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(54, 26);
            this.txtCant.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label9.Location = new System.Drawing.Point(267, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 44);
            this.label9.TabIndex = 12;
            this.label9.Text = "$";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblCotizacion.Location = new System.Drawing.Point(306, 542);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(230, 44);
            this.lblCotizacion.TabIndex = 13;
            this.lblCotizacion.Text = "__________";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCodigo.Location = new System.Drawing.Point(254, 147);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(235, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "|";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLinkHistorial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNomApe);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizador Express";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblNomApe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblLinkHistorial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdPantalon;
        private System.Windows.Forms.RadioButton rdCamisa;
        private System.Windows.Forms.CheckBox chkChupin;
        private System.Windows.Forms.CheckBox chkCuelloMao;
        private System.Windows.Forms.CheckBox chkMangaCorta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdPremium;
        private System.Windows.Forms.RadioButton rdStandar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label2;
    }
}

