
namespace cotizador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.lblNombreApellidoVendedor = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChupin = new System.Windows.Forms.CheckBox();
            this.cbCuelloMao = new System.Windows.Forms.CheckBox();
            this.cbMangaCorta = new System.Windows.Forms.CheckBox();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrecioU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDireccionTienda);
            this.groupBox1.Controls.Add(this.lblNombreTienda);
            this.groupBox1.Location = new System.Drawing.Point(48, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Location = new System.Drawing.Point(439, 37);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(123, 15);
            this.lblDireccionTienda.TabIndex = 1;
            this.lblDireccionTienda.Text = "Dirección de la Tienda";
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Location = new System.Drawing.Point(7, 37);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(89, 15);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnHistorial);
            this.groupBox2.Controls.Add(this.lblCodigoVendedor);
            this.groupBox2.Controls.Add(this.lblNombreApellidoVendedor);
            this.groupBox2.Location = new System.Drawing.Point(48, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "|";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(439, 30);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(186, 23);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial de cotizaciones";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Location = new System.Drawing.Point(196, 38);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(99, 15);
            this.lblCodigoVendedor.TabIndex = 1;
            this.lblCodigoVendedor.Text = "Código Vendedor";
            // 
            // lblNombreApellidoVendedor
            // 
            this.lblNombreApellidoVendedor.AutoSize = true;
            this.lblNombreApellidoVendedor.Location = new System.Drawing.Point(17, 38);
            this.lblNombreApellidoVendedor.Name = "lblNombreApellidoVendedor";
            this.lblNombreApellidoVendedor.Size = new System.Drawing.Size(160, 15);
            this.lblNombreApellidoVendedor.TabIndex = 0;
            this.lblNombreApellidoVendedor.Text = "Nombre y Apellido Vendedor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbChupin);
            this.groupBox3.Controls.Add(this.cbCuelloMao);
            this.groupBox3.Controls.Add(this.cbMangaCorta);
            this.groupBox3.Controls.Add(this.rbPantalon);
            this.groupBox3.Controls.Add(this.rbCamisa);
            this.groupBox3.Location = new System.Drawing.Point(48, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prenda";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(-56, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(817, 2);
            this.label5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 2);
            this.label1.TabIndex = 5;
            // 
            // cbChupin
            // 
            this.cbChupin.AutoSize = true;
            this.cbChupin.Enabled = false;
            this.cbChupin.Location = new System.Drawing.Point(306, 111);
            this.cbChupin.Name = "cbChupin";
            this.cbChupin.Size = new System.Drawing.Size(65, 19);
            this.cbChupin.TabIndex = 4;
            this.cbChupin.Text = "Chupín";
            this.cbChupin.UseVisualStyleBackColor = true;
            this.cbChupin.CheckedChanged += new System.EventHandler(this.cbChupin_CheckedChanged);
            // 
            // cbCuelloMao
            // 
            this.cbCuelloMao.AutoSize = true;
            this.cbCuelloMao.Location = new System.Drawing.Point(468, 43);
            this.cbCuelloMao.Name = "cbCuelloMao";
            this.cbCuelloMao.Size = new System.Drawing.Size(87, 19);
            this.cbCuelloMao.TabIndex = 3;
            this.cbCuelloMao.Text = "Cuello mao";
            this.cbCuelloMao.UseVisualStyleBackColor = true;
            this.cbCuelloMao.CheckedChanged += new System.EventHandler(this.cbCuelloMao_CheckedChanged);
            // 
            // cbMangaCorta
            // 
            this.cbMangaCorta.AutoSize = true;
            this.cbMangaCorta.Location = new System.Drawing.Point(306, 43);
            this.cbMangaCorta.Name = "cbMangaCorta";
            this.cbMangaCorta.Size = new System.Drawing.Size(93, 19);
            this.cbMangaCorta.TabIndex = 2;
            this.cbMangaCorta.Text = "Manga corta";
            this.cbMangaCorta.UseVisualStyleBackColor = true;
            this.cbMangaCorta.CheckedChanged += new System.EventHandler(this.cbMangaCorta_CheckedChanged);
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Location = new System.Drawing.Point(34, 111);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(72, 19);
            this.rbPantalon.TabIndex = 1;
            this.rbPantalon.Text = "Pantalón";
            this.rbPantalon.UseVisualStyleBackColor = true;
            this.rbPantalon.CheckedChanged += new System.EventHandler(this.rbPantalon_CheckedChanged);
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Checked = true;
            this.rbCamisa.Location = new System.Drawing.Point(34, 42);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(64, 19);
            this.rbCamisa.TabIndex = 0;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            this.rbCamisa.CheckedChanged += new System.EventHandler(this.rbCamisa_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStock);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(48, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(706, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(182, 34);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 15);
            this.lblStock.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unidades de stock disponibles:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbPremium);
            this.groupBox5.Controls.Add(this.rbStandard);
            this.groupBox5.Location = new System.Drawing.Point(48, 451);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 90);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calidad";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(167, 39);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(74, 19);
            this.rbPremium.TabIndex = 1;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(58, 39);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(72, 19);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbStandard_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbCantidad);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.tbPrecioU);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(400, 451);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(354, 90);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Precio unitario y cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(238, 39);
            this.tbCantidad.MaxLength = 9;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(80, 23);
            this.tbCantidad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad";
            // 
            // tbPrecioU
            // 
            this.tbPrecioU.Location = new System.Drawing.Point(51, 40);
            this.tbPrecioU.MaxLength = 30;
            this.tbPrecioU.Name = "tbPrecioU";
            this.tbPrecioU.Size = new System.Drawing.Size(80, 23);
            this.tbPrecioU.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "$";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-8, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(810, 2);
            this.label6.TabIndex = 6;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(58, 598);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(250, 50);
            this.btnCotizar.TabIndex = 7;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(434, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 45);
            this.label7.TabIndex = 8;
            this.label7.Text = "$";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(458, 598);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(33, 45);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cotización";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNombreApellidoVendedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPantalon;
        private System.Windows.Forms.RadioButton rbCamisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbChupin;
        private System.Windows.Forms.CheckBox cbCuelloMao;
        private System.Windows.Forms.CheckBox cbMangaCorta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbPremium;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrecioU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCodigoVendedor;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label label8;
    }
}

